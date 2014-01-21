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
            Properties.Settings.Default.Save();

            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Float;
            owningForm.ClientSize = new System.Drawing.Size(owningForm.Width, Convert.ToInt32(WidgetHeightValue.Text));
            owningForm.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;

            // After the form is resized, resize and position the elements
            owningForm.txtChat.Size = new System.Drawing.Size(owningForm.Width - 24, Convert.ToInt32(WidgetHeightValue.Text) - 37);
            owningForm.txtMessage.Size = new System.Drawing.Size(owningForm.Width - 87, owningForm.txtMessage.Size.Height);
            owningForm.txtMessage.Location = new System.Drawing.Point(12, Convert.ToInt32(WidgetHeightValue.Text) - 18);
            owningForm.btnSend.Location = new System.Drawing.Point(owningForm.Width - 70, Convert.ToInt32(WidgetHeightValue.Text) - 18);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            owningForm = (bar)this.Owner;
            WidgetHeightValue.Text = Properties.Settings.Default.WidgetHeight;
        }
    }
}
