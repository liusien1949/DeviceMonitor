namespace DeviceMonitor.App.UI
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.CurrentTemperatureLabel = new System.Windows.Forms.Label();
            this.LastUpdatedLabel = new System.Windows.Forms.Label();
            this.TemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TemperatureGrid = new System.Windows.Forms.DataGridView();
            this.StartLoggingButton = new System.Windows.Forms.Button();
            this.StopLoggingButton = new System.Windows.Forms.Button();
            this.AlarmStatusLabel = new System.Windows.Forms.Label();
            this.AlarmSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(12, 12);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(121, 23);
            this.PortsComboBox.TabIndex = 0;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(139, 12);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 23);
            this.BaudRateComboBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(266, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(94, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(366, 16);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(95, 15);
            this.ConnectionStatusLabel.TabIndex = 3;
            this.ConnectionStatusLabel.Text = "Not connected";
            // 
            // CurrentTemperatureLabel
            // 
            this.CurrentTemperatureLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentTemperatureLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.CurrentTemperatureLabel.Location = new System.Drawing.Point(12, 48);
            this.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel";
            this.CurrentTemperatureLabel.Size = new System.Drawing.Size(348, 75);
            this.CurrentTemperatureLabel.TabIndex = 4;
            this.CurrentTemperatureLabel.Text = "--.- ℃";
            this.CurrentTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastUpdatedLabel
            // 
            this.LastUpdatedLabel.AutoSize = true;
            this.LastUpdatedLabel.Location = new System.Drawing.Point(12, 123);
            this.LastUpdatedLabel.Name = "LastUpdatedLabel";
            this.LastUpdatedLabel.Size = new System.Drawing.Size(124, 15);
            this.LastUpdatedLabel.TabIndex = 5;
            this.LastUpdatedLabel.Text = "Last updated: --:--:--";
            // 
            // TemperatureChart
            // 
            this.TemperatureChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Title = "Temperature (℃)";
            chartArea1.Name = "ChartArea1";
            this.TemperatureChart.ChartAreas.Add(chartArea1);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Temperature";
            this.TemperatureChart.Series.Add(series1);
            this.TemperatureChart.Location = new System.Drawing.Point(12, 150);
            this.TemperatureChart.Name = "TemperatureChart";
            this.TemperatureChart.Size = new System.Drawing.Size(776, 250);
            this.TemperatureChart.TabIndex = 6;
            this.TemperatureChart.Text = "chart1";
            // 
            // TemperatureGrid
            // 
            this.TemperatureGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemperatureGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TemperatureGrid.ReadOnly = true;
            this.TemperatureGrid.AllowUserToAddRows = false;
            this.TemperatureGrid.AllowUserToDeleteRows = false;
            this.TemperatureGrid.RowHeadersVisible = false;
            this.TemperatureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TemperatureGrid.Location = new System.Drawing.Point(12, 406);
            this.TemperatureGrid.Name = "TemperatureGrid";
            this.TemperatureGrid.RowTemplate.Height = 25;
            this.TemperatureGrid.Size = new System.Drawing.Size(776, 150);
            this.TemperatureGrid.TabIndex = 7;
            // 
            // StartLoggingButton
            // 
            this.StartLoggingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartLoggingButton.Location = new System.Drawing.Point(12, 562);
            this.StartLoggingButton.Name = "StartLoggingButton";
            this.StartLoggingButton.Size = new System.Drawing.Size(94, 23);
            this.StartLoggingButton.TabIndex = 8;
            this.StartLoggingButton.Text = "Start Logging";
            this.StartLoggingButton.UseVisualStyleBackColor = true;
            this.StartLoggingButton.Click += new System.EventHandler(this.StartLoggingButton_Click);
            // 
            // StopLoggingButton
            // 
            this.StopLoggingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopLoggingButton.Enabled = false;
            this.StopLoggingButton.Location = new System.Drawing.Point(112, 562);
            this.StopLoggingButton.Name = "StopLoggingButton";
            this.StopLoggingButton.Size = new System.Drawing.Size(94, 23);
            this.StopLoggingButton.TabIndex = 9;
            this.StopLoggingButton.Text = "Stop Logging";
            this.StopLoggingButton.UseVisualStyleBackColor = true;
            this.StopLoggingButton.Click += new System.EventHandler(this.StopLoggingButton_Click);
            // 
            // AlarmStatusLabel
            // 
            this.AlarmStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AlarmStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.AlarmStatusLabel.Location = new System.Drawing.Point(372, 562);
            this.AlarmStatusLabel.Name = "AlarmStatusLabel";
            this.AlarmStatusLabel.Size = new System.Drawing.Size(235, 23);
            this.AlarmStatusLabel.TabIndex = 10;
            this.AlarmStatusLabel.Text = "Alarm: Normal";
            this.AlarmStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AlarmSettingsButton
            // 
            this.AlarmSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AlarmSettingsButton.Location = new System.Drawing.Point(613, 562);
            this.AlarmSettingsButton.Name = "AlarmSettingsButton";
            this.AlarmSettingsButton.Size = new System.Drawing.Size(175, 23);
            this.AlarmSettingsButton.TabIndex = 11;
            this.AlarmSettingsButton.Text = "Alarm Settings";
            this.AlarmSettingsButton.UseVisualStyleBackColor = true;
            this.AlarmSettingsButton.Click += new System.EventHandler(this.AlarmSettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.AlarmSettingsButton);
            this.Controls.Add(this.AlarmStatusLabel);
            this.Controls.Add(this.StopLoggingButton);
            this.Controls.Add(this.StartLoggingButton);
            this.Controls.Add(this.TemperatureGrid);
            this.Controls.Add(this.TemperatureChart);
            this.Controls.Add(this.LastUpdatedLabel);
            this.Controls.Add(this.CurrentTemperatureLabel);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BaudRateComboBox);
            this.Controls.Add(this.PortsComboBox);
            this.Name = "MainForm";
            this.Text = "Temperature Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsComboBox = null!;
        private System.Windows.Forms.ComboBox BaudRateComboBox = null!;
        private System.Windows.Forms.Button ConnectButton = null!;
        private System.Windows.Forms.Label ConnectionStatusLabel = null!;
        private System.Windows.Forms.Label CurrentTemperatureLabel = null!;
        private System.Windows.Forms.Label LastUpdatedLabel = null!;
        private System.Windows.Forms.DataVisualization.Charting.Chart TemperatureChart = null!;
        private System.Windows.Forms.DataGridView TemperatureGrid = null!;
        private System.Windows.Forms.Button StartLoggingButton = null!;
        private System.Windows.Forms.Button StopLoggingButton = null!;
        private System.Windows.Forms.Label AlarmStatusLabel = null!;
        private System.Windows.Forms.Button AlarmSettingsButton = null!;
    }
}
