/**
 * IRCBar
 * @package IRCBar
 * @desc Docked IRC Chat Widget
 * @author Josh Richard <josh.richard@gmail.com>
 * @see http://theyconfuse.me/code/IRCBar
 * @license GPL
 * @license http://theyconfuse.me/license/gpl
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using Meebey.SmartIrc4net;
using Meebey.SmartIrc4net.Delegates;
using System.Threading;

namespace IRCBar
{
    public partial class bar : ShellLib.ApplicationDesktopToolbar
    {
        public static IrcClient irc = new IrcClient();
        private static Settings SettingsForm { get; set; }
        private static Random _r = new Random();
        public int PORT = 6667;

        /* Connection Status */
            public bool connection_status = false;
        /* Userstring */
            private static string USER = "C0NFUS3D IRC Bar";
        /* Default Nickname */
            public string NICK = "barc_" + _r.Next();
        /* Current chat room */
            public string _ROOM;
        /* IRC Server */
            public string _SERVER;
        /* Chat room topic */
            public string _TOPIC;
        /* List of currently connected users */
            public List<string> _CurrentUsers = new List<string>();
        /* IRC Process Thread */
            public Thread irclisten;

            private static ChannelInformation _ChannelInformation { get; set; }

            delegate void SetTextCallback(string text);

        public bar()
        {
            InitializeComponent();

            if (Properties.Settings.Default.PreferredNickname != "")
            {
                NICK = Properties.Settings.Default.PreferredNickname;
            }

            irc.SendDelay = 200;
            irc.AutoRetry = true;
            irc.ChannelSyncing = true;
            irc.OnQueryMessage += new MessageEventHandler(OnQueryMessage);
            irc.OnRawMessage += new MessageEventHandler(OnRawMessage);
            irc.OnJoin += OnJoin;
            irc.OnQuit += OnQuit;
            irc.OnKick += OnKick;
            irc.OnBan += OnBan;
            irc.OnUnban += OnUnban;
            irc.OnPart += OnPart;
            irc.OnNameReply += OnNameReply;
            irc.OnTopic += OnTopic;
            irc.OnWho += OnWho;
            irc.OnTopicChange += OnTopicChange;
            irc.OnChannelMessage += OnChannelMessage;
            irc.OnNickChange += OnNickChange;

            txtChat.LinkClicked += Link_Clicked;
            SettingsForm = new Settings();
            _ChannelInformation = new ChannelInformation();
        }

        private void bar_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Autoconnect == true)
            {
                if (Properties.Settings.Default.DefaultServerPort != "")
                {
                    PORT = Convert.ToInt32(Properties.Settings.Default.DefaultServerPort);
                }
                txtChat.Text = "Connecting to " + Properties.Settings.Default.DefaultServer + " on port " + PORT + " ...";

                if (irc.Connect(Properties.Settings.Default.DefaultServer, PORT) == true)
                {
                    irc.Login(NICK, USER);
                    connection_status = true;
                    _SERVER = Properties.Settings.Default.DefaultServer;
                    txtChat.Text += "\n" + "Connected to " + Properties.Settings.Default.DefaultServer;

                    if (Properties.Settings.Default.DefaultChannel == "")
                    {
                        txtChat.Text += "\n" + "Type: /join #ROOM" +
                            "\nEx: /join #chat";
                    }
                    else
                    {
                        _ROOM = Properties.Settings.Default.DefaultChannel;
                        txtChat.Text = "Joining Room " + _ROOM + " on " + _SERVER + " ...";
                        irc.Join(_ROOM);

                        if (btnChannelInformation.Enabled == false)
                        {
                            btnChannelInformation.Enabled = true;
                        }

                        if (IconMenuChannelInformation.Enabled == false)
                        {
                            IconMenuChannelInformation.Enabled = true;
                        }

                        try
                        {
                            irclisten.Abort();
                        }

                        catch
                        {

                        }

                        // Spawn a thread to handle the listen.
                        irclisten = new Thread(new ThreadStart(IrcListenThread));
                        irclisten.Start();
                    }
                }
                else
                {
                    txtChat.Text += "\n" + "Error: Could not connect.";
                }
            }
            else
            {
                if (Properties.Settings.Default.DefaultServer != "")
                {
                    if (Properties.Settings.Default.DefaultServerPort != "")
                    {
                        PORT = Convert.ToInt32(Properties.Settings.Default.DefaultServerPort);
                    }
                    txtMessage.Text = "/connect " + Properties.Settings.Default.DefaultServer + " " + PORT.ToString();
                }
            }
        }

        private void IconMenuExit_Click(object sender, EventArgs e)
        {
            if (connection_status)
            {
                irclisten.Abort();
            }
            Application.Exit();
        }

        private void IconMenuChannelInformation_Click(object sender, EventArgs e)
        {
            if (!_ChannelInformation.Visible)
            {
                try
                {
                    _ChannelInformation.Show(this);
                }
                catch
                {
                    _ChannelInformation = new ChannelInformation();
                    _ChannelInformation.Show(this);
                }

                _ChannelInformation.BringToFront();
            }
            else
            {
                _ChannelInformation.BringToFront();
            }
        }

        private void IconMenuSettings_Click(object sender, EventArgs e)
        {
            if (!SettingsForm.Visible)
            {
                try
                {
                    SettingsForm.Show(this);
                }
                catch
                {
                    SettingsForm = new Settings();
                    SettingsForm.Show(this);
                }

                SettingsForm.BringToFront();
            }
            else
            {
                SettingsForm.BringToFront();
            }
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        public void OnWho(string channel, string nick, string ident, string host, string realname, bool away, bool op, bool voice, bool ircop, string server, int hopcount, Data ircdata)
        {
            //
        }

        public void OnTopic(string channel, string topic, Data ircdata)
        {
            if (_ROOM == channel)
            {
                _TOPIC = topic;
                SetText("The current topic is: " + topic);
            }
        }

        public void OnTopicChange(string channel, string who, string newtopic, Data ircdata)
        {
            if (_ROOM == channel)
            {
                _TOPIC = newtopic;
                SetText("\n" + DateTime.Now + ": " + who + " has changed the topic: " + newtopic);
            }
        }

        public void OnBan(string channel, string who, string userhostmask, Data ircdata)
        {
            if (_ROOM == channel)
            {
                SetText("\n" + DateTime.Now + ": " + who + " has banned " + userhostmask);
            }
        }

        public void OnUnban(string channel, string who, string userhostmask, Data ircdata)
        {
            if (_ROOM == channel)
            {
                SetText("\n" + DateTime.Now + ": " + who + " has unbanned " + userhostmask);
            }
        }

        private void OnKick(string channel, string victim, string who, string reason, Data ircdata)
        {
            if (_ROOM == channel)
            {
                SetText("\n" + DateTime.Now + ": " + who + " has kicked " + victim + " - " + reason);
            }
        }

        private void OnPart(string channel, string who, string partmessage, Data ircdata)
        {
            if (_ROOM == channel)
            {
                _CurrentUsers.Remove(who);
                SetText("\n" + DateTime.Now + ": " + who + " has left - " + partmessage);
            }
        }

        public void OnNickChange(string oldnickname, string newnickname, Data ircdata)
        {
            _CurrentUsers.Remove(oldnickname);
            _CurrentUsers.Add(newnickname);
            SetText("\n" + DateTime.Now + ": " + oldnickname + " is now known as " + newnickname);
        }

        public void OnNameReply(string channel, string[] userlist, Data ircdata)
        {
            if (_ROOM == channel)
            {
                foreach (string bit in userlist)
                {
                    _CurrentUsers.Add(bit);
                }

                string currentUsers = string.Join(", ", userlist);
                SetText("\nCurrent Users: " + currentUsers.Substring(0, currentUsers.Length - 2));
            }
        }

        public void OnQuit(string who, string quitmessage, Data ircdata)
        {
            _CurrentUsers.Remove(who);
            SetText("\n" + DateTime.Now + ": " + who + " has quit");
        }

        public void OnJoin(string channelname, string who, Data ircdata)
        {
            if (_ROOM == channelname)
            {
                _CurrentUsers.Add(who);
                SetText("\n" + DateTime.Now + ": " + who + " has joined the chat.");
                
            }
        }

        public void OnQueryMessage(Data ircdata)
        {
            SetText("\n" + DateTime.Now + ": Private Message From " + ircdata.Nick + ": " + ircdata.Message);
        }

        public void OnChannelMessage(Data ircdata)
        {
            SetText("\n" + DateTime.Now + ": " + ircdata.Nick + ": " + ircdata.Message);
        }

        public void OnRawMessage(Data ircdata)
        {
            /*if (ircdata.RawMessage.Substring(1, 4) == "PING")
            {
            }
            else
            {
                SetText("\n" + ircdata.Nick + ": " + ircdata.RawMessage);
            }*/
        }

        private void SetText(string text)
        {

            if (this.txtChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtChat.Text += text;

                /* Go to the current position in the chat */
                    this.txtChat.SelectionStart = txtChat.Text.Length;
                    this.txtChat.ScrollToCaret();
            }
        }


        private void btnChannelInformation_Click(object sender, EventArgs e)
        {
            if (!_ChannelInformation.Visible)
            {
                try
                {
                    _ChannelInformation.Show(this);
                }
                catch
                {
                    _ChannelInformation = new ChannelInformation();
                    _ChannelInformation.Show(this);
                }

                _ChannelInformation.BringToFront();
            }
            else
            {
                _ChannelInformation.BringToFront();
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            /* Exit Application */
            if (txtMessage.Text == "/exit" || txtMessage.Text == "/quit")
            {
                if (connection_status)
                {
                    irclisten.Abort();
                }
                Application.Exit();
            }

            /* Connection Statu: Not connected */
                if (connection_status == false)
                {
                    /* Connect to a network */
                    if (txtMessage.Text.Contains("/connect ") == true)
                            {
                                string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                    StringSplitOptions.None);
                                        /* Get the server to connect to */
                                        _SERVER = pieces[1];
                                        /* Get the port to connect to */
                                        if (pieces.Length > 2)
                                        {
                                            if (pieces[2] != "")
                                            {
                                                PORT = Convert.ToInt32(pieces[2]);
                                            }
                                        }
                                        txtChat.Text = "Connecting to " + _SERVER + " on port " + PORT + " ...";

                                        if (irc.Connect(_SERVER, PORT) == true)
                                        {
                                    irc.Login(NICK, USER);
                                    connection_status = true;
                                    txtChat.Text += "\n" + "Connected to " + _SERVER;

                                    if (Properties.Settings.Default.DefaultChannel == "")
                                    {
                                        txtChat.Text += "\n" + "Type: /join #ROOM" +
                                            "\nEx: /join #chat";
                                    }
                                    else
                                    {
                                        _ROOM = Properties.Settings.Default.DefaultChannel;
                                        txtChat.Text = "Joining Room " + _ROOM + " on " + _SERVER + " ...";
                                        irc.Join(_ROOM);

                                        if (btnChannelInformation.Enabled == false)
                                        {
                                            btnChannelInformation.Enabled = true;
                                        }

                                        if (IconMenuChannelInformation.Enabled == false)
                                        {
                                            IconMenuChannelInformation.Enabled = true;
                                        }

                                        try
                                        {
                                            irclisten.Abort();
                                        }

                                        catch
                                        {

                                        }

                                        // Spawn a thread to handle the listen.
                                        irclisten = new Thread(new ThreadStart(IrcListenThread));
                                        irclisten.Start();
                                    }
                                }
                                else
                                {
                                    txtChat.Text += "\n" + "Error: Could not connect.";
                                }
                            }
                }

            /* Connection Status: connected */
                else
                {
                    /* Join Chat Room */
                    if (txtMessage.Text.Contains("/join ") == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        _ROOM = pieces[1];
                        txtChat.Text = "Joining Room " + _ROOM + " on " + _SERVER + " ...";
                        irc.Join(_ROOM);

                        if (btnChannelInformation.Enabled == false)
                        {
                            btnChannelInformation.Enabled = true;
                        }

                        if (IconMenuChannelInformation.Enabled == false)
                        {
                            IconMenuChannelInformation.Enabled = true;
                        }

                        try
                        {
                            irclisten.Abort();
                        }

                        catch
                        {

                        }

                        // Spawn a thread to handle the listen.
                        irclisten = new Thread(new ThreadStart(IrcListenThread));
                        irclisten.Start();
                    }

                    /* Change Nick */
                    else if (txtMessage.Text.Contains("/nick ") == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        NICK = pieces[1];
                        irc.Login(NICK, USER);
                    }

                    /* Private Message */
                    else if (txtMessage.Text.Contains("/msg ") == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        int xvar = pieces[1].Length + 5;

                        irc.Message(SendType.Message, pieces[1], txtMessage.Text.Substring(xvar));
                        txtChat.Text += "\n" + DateTime.Now + ": " + NICK + " to " + pieces[1] + ": " + txtMessage.Text.Substring(xvar);
                    }

                    /* Private Message */
                    else if (txtMessage.Text.Contains("/me ") == true)
                    {
                        irc.Message(SendType.Action, _ROOM, txtMessage.Text.Substring(4));
                        txtChat.Text += "\n" + DateTime.Now + ": " + NICK + " is " + txtMessage.Text.Substring(4);
                    }

                    /* Send Message */
                    else
                    {
                        if (txtMessage.Text != "")
                        {
                                irc.Message(SendType.Message, _ROOM, txtMessage.Text);
                                txtChat.Text += "\n" + DateTime.Now + ": " + NICK + ": " + txtMessage.Text;
                        }
                    }

                }

            /* Clear the input box */
                txtMessage.Text = "";

            /* Go to the current position in the chat */
                txtChat.SelectionStart = txtChat.Text.Length;
                txtChat.ScrollToCaret();
        }

        private void IrcListenThread()
        {
            while (connection_status)
            {
                irc.Listen();
            }
        }



    }
}
