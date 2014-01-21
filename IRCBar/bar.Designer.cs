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
            this.btnSend = new System.Windows.Forms.Button();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bar));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.TheIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(957, 70);
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
            this.txtMessage.Location = new System.Drawing.Point(12, 72);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(871, 23);
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
            this.txtChat.Size = new System.Drawing.Size(999, 53);
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
            this.ClientSize = new System.Drawing.Size(1280, 90);
            this.ControlBox = false;
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.IconMenu.ResumeLayout(false);
            this.Edge = IRCBar.ShellLib.ApplicationDesktopToolbar.AppBarEdges.Top;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            // After the form is resized, resize and position the elements
            this.txtChat.Size = new System.Drawing.Size(this.Width - 24, this.txtChat.Size.Height);
            this.txtMessage.Size = new System.Drawing.Size(this.Width - 87, this.txtMessage.Size.Height);
            this.btnSend.Location = new System.Drawing.Point(this.Width - 70, 72);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IRC Bar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.NotifyIcon TheIcon;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem IconMenuExit;
        private System.Windows.Forms.ToolStripMenuItem IconMenuSettings;
    }
}

