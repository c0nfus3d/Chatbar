using System;
namespace IRCBar
{
    partial class bar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bar));
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.TheIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabpage_0 = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnChannelInformation = new System.Windows.Forms.Button();
            this.chatTabs = new System.Windows.Forms.TabControl();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.IconMenu.SuspendLayout();
            this.chatTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(1, 22);
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtChat.Size = new System.Drawing.Size(1023, 69);
            this.txtChat.TabIndex = 4;
            this.txtChat.Text = "Welcome to the IRC Bar - http://TheyConfuse.Me/Code/IRCBar \nType: /connect <serve" +
                "r.address> <port #>\nEx: /connect irc.freenode.net 6667";
            // 
            // TheIcon
            // 
            this.TheIcon.ContextMenuStrip = this.IconMenu;
            this.TheIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TheIcon.Icon")));
            this.TheIcon.Text = "IRC Bar";
            this.TheIcon.Visible = true;
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMenuSettings,
            this.IconMenuExit});
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // IconMenuSettings
            // 
            this.IconMenuSettings.Name = "IconMenuSettings";
            this.IconMenuSettings.Size = new System.Drawing.Size(116, 22);
            this.IconMenuSettings.Text = "&Settings";
            this.IconMenuSettings.Click += new System.EventHandler(this.IconMenuSettings_Click);
            // 
            // IconMenuExit
            // 
            this.IconMenuExit.Name = "IconMenuExit";
            this.IconMenuExit.Size = new System.Drawing.Size(116, 22);
            this.IconMenuExit.Text = "E&xit";
            this.IconMenuExit.Click += new System.EventHandler(this.IconMenuExit_Click);
            // 
            // tabpage_0
            // 
            this.tabpage_0.Location = new System.Drawing.Point(4, 22);
            this.tabpage_0.Name = "tabpage_0";
            this.tabpage_0.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_0.Size = new System.Drawing.Size(1020, 65);
            this.tabpage_0.TabIndex = 0;
            this.tabpage_0.Text = "[New Connection]";
            this.tabpage_0.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(954, 97);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 21);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnChannelInformation
            // 
            this.btnChannelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChannelInformation.Enabled = false;
            this.btnChannelInformation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChannelInformation.Location = new System.Drawing.Point(850, 97);
            this.btnChannelInformation.Name = "btnChannelInformation";
            this.btnChannelInformation.Size = new System.Drawing.Size(105, 21);
            this.btnChannelInformation.TabIndex = 3;
            this.btnChannelInformation.Text = "Information";
            this.btnChannelInformation.UseVisualStyleBackColor = true;
            this.btnChannelInformation.Click += new System.EventHandler(this.btnChannelInformation_Click);
            // 
            // chatTabs
            // 
            this.chatTabs.Controls.Add(this.tabpage_0);
            this.chatTabs.Location = new System.Drawing.Point(0, 0);
            this.chatTabs.Name = "chatTabs";
            this.chatTabs.SelectedIndex = 0;
            this.chatTabs.Size = new System.Drawing.Size(1028, 91);
            this.chatTabs.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(0, 97);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(844, 21);
            this.txtMessage.TabIndex = 6;
            // 
            // bar
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 120);
            this.ControlBox = false;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnChannelInformation);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chatTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bar";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IRC Chat Bar";
            this.Load += new System.EventHandler(this.bar_Load);
            this.IconMenu.ResumeLayout(false);
            this.chatTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.NotifyIcon TheIcon;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem IconMenuExit;
        private System.Windows.Forms.ToolStripMenuItem IconMenuSettings;
        private System.Windows.Forms.TabPage tabpage_0;
        public System.Windows.Forms.Button btnChannelInformation;
        public System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl chatTabs;
        public System.Windows.Forms.TextBox txtMessage;
    }
}

