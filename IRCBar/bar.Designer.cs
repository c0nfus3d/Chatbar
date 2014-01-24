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
            this.SettHeight = Convert.ToInt32(Properties.Settings.Default.WidgetHeight);
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnChannelInformation = new System.Windows.Forms.Button();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bar));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.TheIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenuChannelInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChannelInformation
            // 
            this.btnChannelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChannelInformation.Location = new System.Drawing.Point(857, 70);
            this.btnChannelInformation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChannelInformation.Name = "btnChannelInformation";
            this.btnChannelInformation.Size = new System.Drawing.Size(105, 23);
            this.btnChannelInformation.TabIndex = 3;
            this.btnChannelInformation.Text = "Information";
            this.btnChannelInformation.Enabled = false;
            this.btnChannelInformation.UseVisualStyleBackColor = true;
            this.btnChannelInformation.Click += new System.EventHandler(this.btnChannelInformation_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(889, 70);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TheIcon
            // 
            this.TheIcon.ContextMenuStrip = this.IconMenu;
            this.TheIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.TheIcon.Text = "C0NFUS3D Widget";
            this.TheIcon.Visible = true;
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMenuChannelInformation,
            this.IconMenuSettings,
            this.IconMenuExit});
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // IconMenuSettings
            // 
            this.IconMenuSettings.Name = "IconMenuSettings";
            this.IconMenuSettings.Size = new System.Drawing.Size(152, 22);
            this.IconMenuSettings.Text = "&Settings";
            this.IconMenuSettings.Click += new System.EventHandler(this.IconMenuSettings_Click);
            // 
            // IconMenuChannelInformation
            // 
            this.IconMenuChannelInformation.Name = "IconMenuChannelInformation";
            this.IconMenuChannelInformation.Size = new System.Drawing.Size(152, 22);
            this.IconMenuChannelInformation.Text = "Channel &Information";
            this.IconMenuChannelInformation.Enabled = false;
            this.IconMenuChannelInformation.Click += new System.EventHandler(this.IconMenuChannelInformation_Click);
            // 
            // IconMenuExit
            // 
            this.IconMenuExit.Name = "IconMenuExit";
            this.IconMenuExit.Size = new System.Drawing.Size(152, 22);
            this.IconMenuExit.Text = "E&xit";
            this.IconMenuExit.Click += new System.EventHandler(this.IconMenuExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, this.SettHeight - 18);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(780, this.SettHeight - 67);
            this.txtMessage.TabIndex = 0;
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(13, 13);
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtChat.Size = new System.Drawing.Size(999, this.SettHeight - 37);
            this.txtChat.TabIndex = 4;
            this.txtChat.Text = "Welcome to the IRC Bar - http://TheyConfuse.Me/Code/IRCBar \nType: /connect <server.address> <port #" +
                ">\nEx: /connect irc.freenode.net 6667";
            // 
            // bar
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ShowInTaskbar = false;
            this.ClientSize = new System.Drawing.Size(1280, this.SettHeight);
            this.ControlBox = false;
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChannelInformation);
            this.IconMenu.ResumeLayout(false);
            this.Load += new System.EventHandler(this.bar_Load);
            this.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            // After the form is resized, resize and position the elements
            this.txtChat.Size = new System.Drawing.Size(this.Width - 24, this.txtChat.Size.Height);
            this.txtMessage.Size = new System.Drawing.Size(this.Width - 202, this.txtMessage.Size.Height);
            this.btnSend.Location = new System.Drawing.Point(this.Width - 185, this.SettHeight - 18);
            this.btnChannelInformation.Location = new System.Drawing.Point(this.Width - 120, this.SettHeight - 18);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IRC Chat Bar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.Button btnChannelInformation;
        public System.Windows.Forms.TextBox txtMessage;
        public System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.NotifyIcon TheIcon;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem IconMenuExit;
        private System.Windows.Forms.ToolStripMenuItem IconMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem IconMenuChannelInformation;
        private int SettHeight;
    }
}

