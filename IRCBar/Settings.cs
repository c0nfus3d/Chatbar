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
            /**
             * TODO
            if (Properties.Settings.Default.DockPosition != this.DockPosition.Text)
            {
                if (this.DockPosition.Text == "Top")
                {
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;
                }
                else
                {
                    owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Bottom;
                }
            }
            */

            Properties.Settings.Default.WidgetHeight = this.WidgetHeightValue.Text;
            Properties.Settings.Default.Autoconnect = this.Autoconnect.Checked;
            Properties.Settings.Default.DefaultServerPort = this.DefaultServerPort.Text;
            Properties.Settings.Default.DefaultServer = this.DefaultServer.Text;
            Properties.Settings.Default.PreferredNickname = this.PreferredNickname.Text;
            Properties.Settings.Default.DefaultChannel = this.AutoJoin.Text;
            Properties.Settings.Default.DockPosition = this.DockPosition.Text;
            Properties.Settings.Default.Save();

            this.Close();

            /**
             * TODO
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
            owningForm.Height = Convert.ToInt32(this.WidgetHeightValue.Text);
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;

            // After the form is resized, resize and position the elements
            owningForm.btnSend.Location = new System.Drawing.Point(owningForm.Width - 185, Convert.ToInt32(this.WidgetHeightValue.Text) - 18);
            owningForm.btnChannelInformation.Location = new System.Drawing.Point(owningForm.Width - 120, Convert.ToInt32(this.WidgetHeightValue.Text) - 18);
            owningForm.txtChat.Size = new System.Drawing.Size(owningForm.Width - 24, owningForm.txtChat.Size.Height);
            owningForm.txtMessage.Size = new System.Drawing.Size(owningForm.Width - 202, owningForm.txtMessage.Size.Height);
             * */
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
