using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace IRCBar
{
    public partial class Settings : Form
    {
        private bar owningForm;

        public Settings()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DockPosition != this.DockPosition.Text)
            {
                if (this.DockPosition.Text == "Top")
                {
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;
                }
                else
                {
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Bottom;
                }
            }

            Properties.Settings.Default.WidgetHeight = this.WidgetHeightValue.Text;
            Properties.Settings.Default.Autoconnect = this.Autoconnect.Checked;
            Properties.Settings.Default.DefaultServerPort = this.DefaultServerPort.Text;
            Properties.Settings.Default.DefaultServer = this.DefaultServer.Text;
            Properties.Settings.Default.PreferredNickname = this.PreferredNickname.Text;
            Properties.Settings.Default.DefaultChannel = this.AutoJoin.Text;
            Properties.Settings.Default.DockPosition = this.DockPosition.Text;
            Properties.Settings.Default.Save();

            this.Close();

            /** # TODO: FIX THIS
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
            owningForm.Height = Convert.ToInt32(this.WidgetHeightValue.Text);
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;

            owningForm.txtChat.Left = 1;
            owningForm.txtChat.Top = owningForm.Height - 95;
            owningForm.txtMessage.Left = 0;
            owningForm.txtMessage.Top = Convert.ToInt32(Properties.Settings.Default.WidgetHeight) - 23;
            owningForm.txtChat.Width = owningForm.Width - 5;
            owningForm.txtChat.Height = owningForm.Height - 51;
            owningForm.txtMessage.Width = owningForm.Width - (owningForm.btnChannelInformation.Width + owningForm.btnSend.Width + 25);
            owningForm.txtMessage.Height = owningForm.txtMessage.Size.Height;
            owningForm.btnSend.Left = owningForm.Width - (owningForm.btnSend.Width + 25);
            owningForm.btnSend.Top = Convert.ToInt32(Properties.Settings.Default.WidgetHeight) - 23;
            owningForm.btnChannelInformation.Left = owningForm.Width - (owningForm.btnChannelInformation.Width + owningForm.btnSend.Width + 25);
            owningForm.btnChannelInformation.Top = Convert.ToInt32(Properties.Settings.Default.WidgetHeight) - 23;
            */
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Text += " -- Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            owningForm = (bar)this.Owner;
            this.WidgetHeightValue.Text = Properties.Settings.Default.WidgetHeight;
            this.Autoconnect.Checked = Properties.Settings.Default.Autoconnect;
            this.DefaultServerPort.Text = Properties.Settings.Default.DefaultServerPort;
            this.DefaultServer.Text = Properties.Settings.Default.DefaultServer;
            this.PreferredNickname.Text = Properties.Settings.Default.PreferredNickname;
            this.AutoJoin.Text = Properties.Settings.Default.DefaultChannel;
            this.DockPosition.Text = Properties.Settings.Default.DockPosition;
        }
    }
}
