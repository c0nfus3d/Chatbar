namespace IRCBar
{
    partial class ChannelInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelInformation));
            this.UserList = new System.Windows.Forms.ListBox();
            this.TopicGroupBox = new System.Windows.Forms.GroupBox();
            this.ChannelName = new System.Windows.Forms.TextBox();
            this.ChannelTopic = new System.Windows.Forms.TextBox();
            this.@__ChannelTopic = new System.Windows.Forms.Label();
            this.@__ChannelName = new System.Windows.Forms.Label();
            this.UserListBox = new System.Windows.Forms.GroupBox();
            this.TopicGroupBox.SuspendLayout();
            this.UserListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(6, 19);
            this.UserList.MaximumSize = new System.Drawing.Size(355, 225);
            this.UserList.MinimumSize = new System.Drawing.Size(355, 225);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(355, 225);
            this.UserList.Sorted = true;
            this.UserList.TabIndex = 0;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // TopicGroupBox
            // 
            this.TopicGroupBox.Controls.Add(this.ChannelName);
            this.TopicGroupBox.Controls.Add(this.ChannelTopic);
            this.TopicGroupBox.Controls.Add(this.@__ChannelTopic);
            this.TopicGroupBox.Controls.Add(this.@__ChannelName);
            this.TopicGroupBox.Location = new System.Drawing.Point(13, 13);
            this.TopicGroupBox.Name = "TopicGroupBox";
            this.TopicGroupBox.Size = new System.Drawing.Size(367, 82);
            this.TopicGroupBox.TabIndex = 1;
            this.TopicGroupBox.TabStop = false;
            this.TopicGroupBox.Text = "Channel";
            // 
            // ChannelName
            // 
            this.ChannelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelName.Location = new System.Drawing.Point(62, 19);
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.ReadOnly = true;
            this.ChannelName.Size = new System.Drawing.Size(299, 21);
            this.ChannelName.TabIndex = 4;
            // 
            // ChannelTopic
            // 
            this.ChannelTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTopic.Location = new System.Drawing.Point(62, 46);
            this.ChannelTopic.Name = "ChannelTopic";
            this.ChannelTopic.ReadOnly = true;
            this.ChannelTopic.Size = new System.Drawing.Size(299, 21);
            this.ChannelTopic.TabIndex = 3;
            // 
            // __ChannelTopic
            // 
            this.@__ChannelTopic.AutoSize = true;
            this.@__ChannelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__ChannelTopic.Location = new System.Drawing.Point(7, 48);
            this.@__ChannelTopic.Name = "__ChannelTopic";
            this.@__ChannelTopic.Size = new System.Drawing.Size(48, 16);
            this.@__ChannelTopic.TabIndex = 2;
            this.@__ChannelTopic.Text = "Topic";
            // 
            // __ChannelName
            // 
            this.@__ChannelName.AutoSize = true;
            this.@__ChannelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@__ChannelName.Location = new System.Drawing.Point(7, 20);
            this.@__ChannelName.Name = "__ChannelName";
            this.@__ChannelName.Size = new System.Drawing.Size(49, 16);
            this.@__ChannelName.TabIndex = 0;
            this.@__ChannelName.Text = "Name";
            // 
            // UserListBox
            // 
            this.UserListBox.Controls.Add(this.UserList);
            this.UserListBox.Location = new System.Drawing.Point(13, 102);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(367, 259);
            this.UserListBox.TabIndex = 2;
            this.UserListBox.TabStop = false;
            this.UserListBox.Text = "Current Users";
            // 
            // ChannelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.TopicGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ChannelInformation";
            this.Text = "Channel Information";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.TopicGroupBox.ResumeLayout(false);
            this.TopicGroupBox.PerformLayout();
            this.UserListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.GroupBox TopicGroupBox;
        private System.Windows.Forms.TextBox ChannelName;
        private System.Windows.Forms.TextBox ChannelTopic;
        private System.Windows.Forms.Label __ChannelTopic;
        private System.Windows.Forms.Label __ChannelName;
        private System.Windows.Forms.GroupBox UserListBox;
    }
}