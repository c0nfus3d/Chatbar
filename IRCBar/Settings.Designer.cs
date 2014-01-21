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
            this.CancelButton = new System.Windows.Forms.Button();
            this.WidgetHeightLabel = new System.Windows.Forms.Label();
            this.WidgetHeightValue = new System.Windows.Forms.TextBox();
            this.LabelGroup = new System.Windows.Forms.GroupBox();
            this.ValueGroup = new System.Windows.Forms.GroupBox();
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
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(297, 342);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "E&xit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WidgetHeightLabel
            // 
            this.WidgetHeightLabel.AutoSize = true;
            this.WidgetHeightLabel.Location = new System.Drawing.Point(6, 16);
            this.WidgetHeightLabel.Name = "WidgetHeightLabel";
            this.WidgetHeightLabel.Size = new System.Drawing.Size(78, 13);
            this.WidgetHeightLabel.TabIndex = 2;
            this.WidgetHeightLabel.Text = "Widget Height:";
            // 
            // WidgetHeightValue
            // 
            this.WidgetHeightValue.Location = new System.Drawing.Point(6, 13);
            this.WidgetHeightValue.Name = "WidgetHeightValue";
            this.WidgetHeightValue.Size = new System.Drawing.Size(216, 20);
            this.WidgetHeightValue.TabIndex = 3;
            // 
            // LabelGroup
            // 
            this.LabelGroup.Controls.Add(this.WidgetHeightLabel);
            this.LabelGroup.Location = new System.Drawing.Point(12, 12);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(207, 324);
            this.LabelGroup.TabIndex = 4;
            this.LabelGroup.TabStop = false;
            this.LabelGroup.Text = "Label";
            // 
            // ValueGroup
            // 
            this.ValueGroup.Controls.Add(this.WidgetHeightValue);
            this.ValueGroup.Location = new System.Drawing.Point(225, 12);
            this.ValueGroup.Name = "ValueGroup";
            this.ValueGroup.Size = new System.Drawing.Size(228, 324);
            this.ValueGroup.TabIndex = 5;
            this.ValueGroup.TabStop = false;
            this.ValueGroup.Text = "Value";
            // 
            // Settings
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 377);
            this.Controls.Add(this.ValueGroup);
            this.Controls.Add(this.LabelGroup);
            this.Controls.Add(this.CancelButton);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label WidgetHeightLabel;
        private System.Windows.Forms.TextBox WidgetHeightValue;
        private System.Windows.Forms.GroupBox LabelGroup;
        private System.Windows.Forms.GroupBox ValueGroup;
    }
}