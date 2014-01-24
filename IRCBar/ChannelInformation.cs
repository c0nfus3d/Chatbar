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
    public partial class ChannelInformation : Form
    {
        private bar ChatBar;
        public ChannelInformation()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            ChatBar = (bar)this.Owner;

            UserList.Items.Clear();
            ChannelName.Text = ChatBar._ROOM;
            ChannelTopic.Text = ChatBar._TOPIC;

            foreach (string bit in ChatBar._CurrentUsers)
            {
                UserList.Items.Add(bit);
            }
        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatBar.txtMessage.Text = "/msg " + UserList.SelectedItem.ToString() + " ";
            ChatBar.txtMessage.Focus();
        }
    }
}
