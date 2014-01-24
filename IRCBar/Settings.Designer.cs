namespace IRCBar
{
    partial class Settings
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
            this.SaveButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this._WidgetHeight = new System.Windows.Forms.Label();
            this.WidgetHeightValue = new System.Windows.Forms.TextBox();
            this.LabelGroup = new System.Windows.Forms.GroupBox();
            this._Autoconnect = new System.Windows.Forms.Label();
            this._DefaultServerPort = new System.Windows.Forms.Label();
            this._DefaultServer = new System.Windows.Forms.Label();
            this._PreferredNickname = new System.Windows.Forms.Label();
            this.ValueGroup = new System.Windows.Forms.GroupBox();
            this.Autoconnect = new System.Windows.Forms.CheckBox();
            this.DefaultServerPort = new System.Windows.Forms.TextBox();
            this.DefaultServer = new System.Windows.Forms.TextBox();
            this.PreferredNickname = new System.Windows.Forms.TextBox();
            this._AutoJoin = new System.Windows.Forms.Label();
            this.AutoJoin = new System.Windows.Forms.TextBox();
            this.LabelGroup.SuspendLayout();
            this.ValueGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(378, 342);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _CancelButton
            // 
            this._CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._CancelButton.Location = new System.Drawing.Point(297, 342);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(75, 23);
            this._CancelButton.TabIndex = 1;
            this._CancelButton.Text = "E&xit";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // _WidgetHeight
            // 
            this._WidgetHeight.AutoSize = true;
            this._WidgetHeight.Location = new System.Drawing.Point(6, 16);
            this._WidgetHeight.Name = "_WidgetHeight";
            this._WidgetHeight.Size = new System.Drawing.Size(78, 13);
            this._WidgetHeight.TabIndex = 2;
            this._WidgetHeight.Text = "Widget Height:";
            // 
            // WidgetHeightValue
            // 
            this.WidgetHeightValue.Enabled = false;
            this.WidgetHeightValue.Location = new System.Drawing.Point(6, 13);
            this.WidgetHeightValue.Name = "WidgetHeightValue";
            this.WidgetHeightValue.Size = new System.Drawing.Size(216, 20);
            this.WidgetHeightValue.TabIndex = 3;
            // 
            // LabelGroup
            // 
            this.LabelGroup.Controls.Add(this._AutoJoin);
            this.LabelGroup.Controls.Add(this._Autoconnect);
            this.LabelGroup.Controls.Add(this._DefaultServerPort);
            this.LabelGroup.Controls.Add(this._DefaultServer);
            this.LabelGroup.Controls.Add(this._PreferredNickname);
            this.LabelGroup.Controls.Add(this._WidgetHeight);
            this.LabelGroup.Location = new System.Drawing.Point(12, 12);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(207, 324);
            this.LabelGroup.TabIndex = 4;
            this.LabelGroup.TabStop = false;
            this.LabelGroup.Text = "Label";
            // 
            // _Autoconnect
            // 
            this._Autoconnect.AutoSize = true;
            this._Autoconnect.Location = new System.Drawing.Point(6, 153);
            this._Autoconnect.Name = "_Autoconnect";
            this._Autoconnect.Size = new System.Drawing.Size(111, 13);
            this._Autoconnect.TabIndex = 6;
            this._Autoconnect.Text = "Autoconnect on Start:";
            // 
            // _DefaultServerPort
            // 
            this._DefaultServerPort.AutoSize = true;
            this._DefaultServerPort.Location = new System.Drawing.Point(6, 117);
            this._DefaultServerPort.Name = "_DefaultServerPort";
            this._DefaultServerPort.Size = new System.Drawing.Size(100, 13);
            this._DefaultServerPort.TabIndex = 5;
            this._DefaultServerPort.Text = "Default Server Port:";
            // 
            // _DefaultServer
            // 
            this._DefaultServer.AutoSize = true;
            this._DefaultServer.Location = new System.Drawing.Point(6, 83);
            this._DefaultServer.Name = "_DefaultServer";
            this._DefaultServer.Size = new System.Drawing.Size(78, 13);
            this._DefaultServer.TabIndex = 4;
            this._DefaultServer.Text = "Default Server:";
            // 
            // _PreferredNickname
            // 
            this._PreferredNickname.AutoSize = true;
            this._PreferredNickname.Location = new System.Drawing.Point(6, 51);
            this._PreferredNickname.Name = "_PreferredNickname";
            this._PreferredNickname.Size = new System.Drawing.Size(104, 13);
            this._PreferredNickname.TabIndex = 3;
            this._PreferredNickname.Text = "Preferred Nickname:";
            // 
            // ValueGroup
            // 
            this.ValueGroup.Controls.Add(this.AutoJoin);
            this.ValueGroup.Controls.Add(this.Autoconnect);
            this.ValueGroup.Controls.Add(this.DefaultServerPort);
            this.ValueGroup.Controls.Add(this.DefaultServer);
            this.ValueGroup.Controls.Add(this.PreferredNickname);
            this.ValueGroup.Controls.Add(this.WidgetHeightValue);
            this.ValueGroup.Location = new System.Drawing.Point(225, 12);
            this.ValueGroup.Name = "ValueGroup";
            this.ValueGroup.Size = new System.Drawing.Size(228, 324);
            this.ValueGroup.TabIndex = 5;
            this.ValueGroup.TabStop = false;
            this.ValueGroup.Text = "Value";
            // 
            // Autoconnect
            // 
            this.Autoconnect.AutoSize = true;
            this.Autoconnect.Location = new System.Drawing.Point(6, 152);
            this.Autoconnect.Name = "Autoconnect";
            this.Autoconnect.Size = new System.Drawing.Size(15, 14);
            this.Autoconnect.TabIndex = 7;
            this.Autoconnect.UseVisualStyleBackColor = true;
            // 
            // DefaultServerPort
            // 
            this.DefaultServerPort.Location = new System.Drawing.Point(6, 114);
            this.DefaultServerPort.Name = "DefaultServerPort";
            this.DefaultServerPort.Size = new System.Drawing.Size(216, 20);
            this.DefaultServerPort.TabIndex = 6;
            // 
            // DefaultServer
            // 
            this.DefaultServer.Location = new System.Drawing.Point(6, 80);
            this.DefaultServer.Name = "DefaultServer";
            this.DefaultServer.Size = new System.Drawing.Size(216, 20);
            this.DefaultServer.TabIndex = 5;
            // 
            // PreferredNickname
            // 
            this.PreferredNickname.Location = new System.Drawing.Point(6, 48);
            this.PreferredNickname.Name = "PreferredNickname";
            this.PreferredNickname.Size = new System.Drawing.Size(216, 20);
            this.PreferredNickname.TabIndex = 4;
            // 
            // _AutoJoin
            // 
            this._AutoJoin.AutoSize = true;
            this._AutoJoin.Location = new System.Drawing.Point(6, 187);
            this._AutoJoin.Name = "_AutoJoin";
            this._AutoJoin.Size = new System.Drawing.Size(54, 13);
            this._AutoJoin.TabIndex = 7;
            this._AutoJoin.Text = "Auto Join:";
            // 
            // AutoJoin
            // 
            this.AutoJoin.Location = new System.Drawing.Point(6, 184);
            this.AutoJoin.Name = "AutoJoin";
            this.AutoJoin.Size = new System.Drawing.Size(216, 20);
            this.AutoJoin.TabIndex = 7;
            // 
            // Settings
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 377);
            this.Controls.Add(this.ValueGroup);
            this.Controls.Add(this.LabelGroup);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.LabelGroup.ResumeLayout(false);
            this.LabelGroup.PerformLayout();
            this.ValueGroup.ResumeLayout(false);
            this.ValueGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Label _WidgetHeight;
        private System.Windows.Forms.TextBox WidgetHeightValue;
        private System.Windows.Forms.GroupBox LabelGroup;
        private System.Windows.Forms.GroupBox ValueGroup;
        private System.Windows.Forms.Label _PreferredNickname;
        private System.Windows.Forms.TextBox PreferredNickname;
        private System.Windows.Forms.Label _Autoconnect;
        private System.Windows.Forms.Label _DefaultServerPort;
        private System.Windows.Forms.Label _DefaultServer;
        private System.Windows.Forms.TextBox DefaultServerPort;
        private System.Windows.Forms.TextBox DefaultServer;
        private System.Windows.Forms.CheckBox Autoconnect;
        private System.Windows.Forms.Label _AutoJoin;
        private System.Windows.Forms.TextBox AutoJoin;
    }
}