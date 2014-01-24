using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            Properties.Settings.Default.WidgetHeight = WidgetHeightValue.Text;
            Properties.Settings.Default.Autoconnect = Autoconnect.Checked;
            Properties.Settings.Default.DefaultServerPort = DefaultServerPort.Text;
            Properties.Settings.Default.DefaultServer = DefaultServer.Text;
            Properties.Settings.Default.PreferredNickname = PreferredNickname.Text;
            Properties.Settings.Default.DefaultChannel = AutoJoin.Text;
            Properties.Settings.Default.Save();

            /*
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
            owningForm.ClientSize = new System.Drawing.Size(owningForm.Width, Convert.ToInt32(WidgetHeightValue.Text));
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;

            // After the form is resized, resize and position the elements
            owningForm.txtChat.Size = new System.Drawing.Size(this.Width - 24, this.txtChat.Size.Height);
            owningForm.txtMessage.Size = new System.Drawing.Size(this.Width - 202, this.txtMessage.Size.Height);
            owningForm.btnSend.Location = new System.Drawing.Point(this.Width - 185, this.SettHeight - 18);
            owningForm.btnChannelInformation.Location = new System.Drawing.Point(this.Width - 120, this.SettHeight - 18);
            */
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            owningForm = (bar)this.Owner;
            WidgetHeightValue.Text = Properties.Settings.Default.WidgetHeight;
            Autoconnect.Checked = Properties.Settings.Default.Autoconnect;
            DefaultServerPort.Text = Properties.Settings.Default.DefaultServerPort;
            DefaultServer.Text = Properties.Settings.Default.DefaultServer;
            PreferredNickname.Text = Properties.Settings.Default.PreferredNickname;
            AutoJoin.Text = Properties.Settings.Default.DefaultChannel;
        }
    }
}
