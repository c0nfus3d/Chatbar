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

        /* Connection Status : Boolean */
            bool connection_status = false;
        /* Define User */
            private static string USER = "C0NFUS3D IRC Bar";
        /* Default Nickname */
            static Random _r = new Random();
            public string NICK = "barc_" + _r.Next();
        /* Define current chat room */
            public string _ROOM;
        /* IRC Process Thread */
            public Thread irclisten;

            delegate void SetTextCallback(string text);

        public bar()
        {
            InitializeComponent();


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
        }

        private void IconMenuExit_Click(object sender, EventArgs e)
        {
            if (connection_status)
            {
                irclisten.Abort();
            }
            Application.Exit();
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
                SetText("The current topic is: " + topic);
            }
        }

        public void OnTopicChange(string channel, string who, string newtopic, Data ircdata)
        {
            if (_ROOM == channel)
            {
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
                SetText("\n" + DateTime.Now + ": " + who + " has left - " + partmessage);
            }
        }

        public void OnNickChange(string oldnickname, string newnickname, Data ircdata)
        {
            SetText("\n" + DateTime.Now + ": " + oldnickname + " is now known as " + newnickname);
        }

        public void OnNameReply(string channel, string[] userlist, Data ircdata)
        {
            if (_ROOM == channel)
            {
                string currentUsers = string.Join(", ", userlist);
                SetText("\nCurrent Users: " + currentUsers);
            }
        }

        public void OnQuit(string who, string quitmessage, Data ircdata)
        {
            SetText("\n" + DateTime.Now + ": " + who + " has quit");
        }

        public void OnJoin(string channelname, string who, Data ircdata)
        {
            if (_ROOM == channelname)
            {
                SetText("\n" + DateTime.Now + ": " + who + " has joined the chat.");
            }
        }

        public void OnQueryMessage(Data ircdata)
        {
            SetText("\n" + DateTime.Now + ": " + ircdata.Nick + ": " + ircdata.Message);
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


        private void btnSend_Click(object sender, EventArgs e)
        {
            /* Connection Statu: Not connected */
                if (connection_status == false)
                {
                    string command_connect = "/connect ";

                    /* Connect to a network */
                            if ( txtMessage.Text.Contains(command_connect) == true)
                            {
                                string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                    StringSplitOptions.None);
                                        /* Get the server to connect to */
                                        string SERVER = pieces[1];
                                        /* Get the port to connect to
                                         * Default: 6667 */
                                        int PORT = 6667;
                                        if (pieces.Length > 2)
                                        {
                                            if (pieces[2] != "")
                                            {
                                                PORT = Convert.ToInt32(pieces[2]);
                                            }
                                        }
                                        txtChat.Text = "Connecting to " + SERVER + " on port " + PORT + " ...";
                                    
                                if(irc.Connect(SERVER, PORT) == true) {
                                    irc.Login(NICK, USER);
                                    connection_status = true;
                                    txtChat.Text += "\n" + "Connected to " + SERVER;
                                    txtChat.Text += "\n" + "Type: /join #ROOM" +
                                        "\nEx: /join #chat";
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
                    string command_nick = "/nick ";
                    string command_join = "/join ";
                    string command_msg = "/msg ";

                    /* Join Chat Room */
                    if (txtMessage.Text.Contains(command_join) == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        _ROOM = pieces[1];
                        txtChat.Text = "Joining Room " + _ROOM + " ...";
                        irc.Join(_ROOM);

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
                    else if (txtMessage.Text.Contains(command_nick) == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        NICK = pieces[1];
                        irc.Login(NICK, USER);
                    }

                    /* Private Message */
                    else if (txtMessage.Text.Contains(command_msg) == true)
                    {
                        string[] pieces = txtMessage.Text.Split(new string[] { " " },
                                StringSplitOptions.None);
                        int xvar = pieces[1].Length + 5;

                        irc.Message(SendType.Message, pieces[1], txtMessage.Text.Substring(xvar));
                        txtChat.Text += "\n" + DateTime.Now + ": " + NICK + ": " + pieces[1] + ": " + txtMessage.Text.Substring(xvar);
                    }

                    /* Send Message */
                    else
                    {
                        if (txtMessage.Text != "")
                        {
                            if (txtMessage.Text.Substring(0, 4) == "/me ")
                            {
                                irc.Message(SendType.Action, _ROOM, txtMessage.Text.Substring(4));
                                txtChat.Text += "\n" + DateTime.Now + ": " + NICK + ": " + txtMessage.Text.Substring(4);
                            }
                            else
                            {
                                irc.Message(SendType.Message, _ROOM, txtMessage.Text);
                                txtChat.Text += "\n" + DateTime.Now + ": " + NICK + ": " + txtMessage.Text;
                            }
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
