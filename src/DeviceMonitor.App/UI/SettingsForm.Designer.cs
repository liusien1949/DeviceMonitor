namespace DeviceMonitor.App.UI
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.LowThresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.HighThresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.LowThresholdLabel = new System.Windows.Forms.Label();
            this.HighThresholdLabel = new System.Windows.Forms.Label();
            this.AlarmEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LowThresholdNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighThresholdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // LowThresholdNumeric
            // 
            this.LowThresholdNumeric.DecimalPlaces = 1;
            this.LowThresholdNumeric.Location = new System.Drawing.Point(156, 12);
            this.LowThresholdNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LowThresholdNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.LowThresholdNumeric.Name = "LowThresholdNumeric";
            this.LowThresholdNumeric.Size = new System.Drawing.Size(120, 23);
            this.LowThresholdNumeric.TabIndex = 0;
            // 
            // HighThresholdNumeric
            // 
            this.HighThresholdNumeric.DecimalPlaces = 1;
            this.HighThresholdNumeric.Location = new System.Drawing.Point(156, 41);
            this.HighThresholdNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.HighThresholdNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.HighThresholdNumeric.Name = "HighThresholdNumeric";
            this.HighThresholdNumeric.Size = new System.Drawing.Size(120, 23);
            this.HighThresholdNumeric.TabIndex = 1;
            // 
            // LowThresholdLabel
            // 
            this.LowThresholdLabel.AutoSize = true;
            this.LowThresholdLabel.Location = new System.Drawing.Point(12, 14);
            this.LowThresholdLabel.Name = "LowThresholdLabel";
            this.LowThresholdLabel.Size = new System.Drawing.Size(138, 15);
            this.LowThresholdLabel.TabIndex = 2;
            this.LowThresholdLabel.Text = "Low threshold (℃):";
            // 
            // HighThresholdLabel
            // 
            this.HighThresholdLabel.AutoSize = true;
            this.HighThresholdLabel.Location = new System.Drawing.Point(12, 43);
            this.HighThresholdLabel.Name = "HighThresholdLabel";
            this.HighThresholdLabel.Size = new System.Drawing.Size(143, 15);
            this.HighThresholdLabel.TabIndex = 3;
            this.HighThresholdLabel.Text = "High threshold (℃):";
            // 
            // AlarmEnabledCheckbox
            // 
            this.AlarmEnabledCheckbox.AutoSize = true;
            this.AlarmEnabledCheckbox.Location = new System.Drawing.Point(15, 74);
            this.AlarmEnabledCheckbox.Name = "AlarmEnabledCheckbox";
            this.AlarmEnabledCheckbox.Size = new System.Drawing.Size(107, 19);
            this.AlarmEnabledCheckbox.TabIndex = 4;
            this.AlarmEnabledCheckbox.Text = "Enable alarm";
            this.AlarmEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(120, 109);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonControl.Location = new System.Drawing.Point(201, 109);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(75, 23);
            this.CancelButtonControl.TabIndex = 6;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            this.CancelButtonControl.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(292, 144);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AlarmEnabledCheckbox);
            this.Controls.Add(this.HighThresholdLabel);
            this.Controls.Add(this.LowThresholdLabel);
            this.Controls.Add(this.HighThresholdNumeric);
            this.Controls.Add(this.LowThresholdNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarm Settings";
            ((System.ComponentModel.ISupportInitialize)(this.LowThresholdNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighThresholdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LowThresholdNumeric = null!;
        private System.Windows.Forms.NumericUpDown HighThresholdNumeric = null!;
        private System.Windows.Forms.Label LowThresholdLabel = null!;
        private System.Windows.Forms.Label HighThresholdLabel = null!;
        private System.Windows.Forms.CheckBox AlarmEnabledCheckbox = null!;
        private System.Windows.Forms.Button SaveButton = null!;
        private System.Windows.Forms.Button CancelButtonControl = null!;
    }
}
