namespace HHPS_DCZM_Interface
{
    partial class Form_Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Erase_Memory = new System.Windows.Forms.Button();
            this.Btn_Download_Memory = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Connect_Device = new System.Windows.Forms.Button();
            this.numeric_SampleTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DevicePower_Box = new System.Windows.Forms.CheckBox();
            this.Combo_TOF_PERIOD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Combo_LPIR_PERIOD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CleanLED_BOX = new System.Windows.Forms.CheckBox();
            this.OPT2_STATE_BOX = new System.Windows.Forms.CheckBox();
            this.OPT3_STATE_BOX = new System.Windows.Forms.CheckBox();
            this.Combo_TxDuration = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Combo_BeaconDuration = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IntervalAlarm_BOX = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DevVersion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Combo_PortList = new System.Windows.Forms.ComboBox();
            this.Numeric_Erros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_DevID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SampleTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DevID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device ID";
            // 
            // Btn_Erase_Memory
            // 
            this.Btn_Erase_Memory.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Erase_Memory.Enabled = false;
            this.Btn_Erase_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Erase_Memory.ForeColor = System.Drawing.Color.Red;
            this.Btn_Erase_Memory.Location = new System.Drawing.Point(477, 124);
            this.Btn_Erase_Memory.Name = "Btn_Erase_Memory";
            this.Btn_Erase_Memory.Size = new System.Drawing.Size(112, 24);
            this.Btn_Erase_Memory.TabIndex = 4;
            this.Btn_Erase_Memory.Text = "Erase Memory";
            this.Btn_Erase_Memory.UseVisualStyleBackColor = false;
            this.Btn_Erase_Memory.Click += new System.EventHandler(this.Btn_Erase_Memory_Click);
            // 
            // Btn_Download_Memory
            // 
            this.Btn_Download_Memory.Enabled = false;
            this.Btn_Download_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Download_Memory.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_Download_Memory.Location = new System.Drawing.Point(477, 171);
            this.Btn_Download_Memory.Name = "Btn_Download_Memory";
            this.Btn_Download_Memory.Size = new System.Drawing.Size(112, 32);
            this.Btn_Download_Memory.TabIndex = 13;
            this.Btn_Download_Memory.Text = "Download Data";
            this.Btn_Download_Memory.UseVisualStyleBackColor = true;
            this.Btn_Download_Memory.Click += new System.EventHandler(this.Btn_Download_Memory_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connect.Location = new System.Drawing.Point(452, 41);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(77, 23);
            this.Btn_Connect.TabIndex = 14;
            this.Btn_Connect.Text = "Open";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Enabled = false;
            this.Btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Disconnect.Location = new System.Drawing.Point(536, 41);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(77, 23);
            this.Btn_Disconnect.TabIndex = 15;
            this.Btn_Disconnect.Text = "Close";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // Connect_Device
            // 
            this.Connect_Device.BackColor = System.Drawing.SystemColors.Control;
            this.Connect_Device.Enabled = false;
            this.Connect_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Device.ForeColor = System.Drawing.Color.Green;
            this.Connect_Device.Location = new System.Drawing.Point(452, 68);
            this.Connect_Device.Name = "Connect_Device";
            this.Connect_Device.Size = new System.Drawing.Size(161, 32);
            this.Connect_Device.TabIndex = 16;
            this.Connect_Device.Text = "Connect to Device";
            this.Connect_Device.UseVisualStyleBackColor = false;
            this.Connect_Device.Click += new System.EventHandler(this.Btn_ConnectDevice_Click);
            // 
            // numeric_SampleTime
            // 
            this.numeric_SampleTime.Location = new System.Drawing.Point(10, 46);
            this.numeric_SampleTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_SampleTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_SampleTime.Name = "numeric_SampleTime";
            this.numeric_SampleTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numeric_SampleTime.Size = new System.Drawing.Size(70, 20);
            this.numeric_SampleTime.TabIndex = 19;
            this.numeric_SampleTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sample Duration";
            // 
            // DevicePower_Box
            // 
            this.DevicePower_Box.AutoSize = true;
            this.DevicePower_Box.Checked = true;
            this.DevicePower_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DevicePower_Box.Location = new System.Drawing.Point(9, 314);
            this.DevicePower_Box.Margin = new System.Windows.Forms.Padding(2);
            this.DevicePower_Box.Name = "DevicePower_Box";
            this.DevicePower_Box.Size = new System.Drawing.Size(93, 17);
            this.DevicePower_Box.TabIndex = 24;
            this.DevicePower_Box.Text = "Device Power";
            this.DevicePower_Box.UseVisualStyleBackColor = true;
            // 
            // Combo_TOF_PERIOD
            // 
            this.Combo_TOF_PERIOD.FormattingEnabled = true;
            this.Combo_TOF_PERIOD.Items.AddRange(new object[] {
            "OFF",
            "50",
            "100",
            "200",
            "250",
            "330",
            "500",
            "750"});
            this.Combo_TOF_PERIOD.Location = new System.Drawing.Point(10, 69);
            this.Combo_TOF_PERIOD.Margin = new System.Windows.Forms.Padding(2);
            this.Combo_TOF_PERIOD.Name = "Combo_TOF_PERIOD";
            this.Combo_TOF_PERIOD.Size = new System.Drawing.Size(71, 21);
            this.Combo_TOF_PERIOD.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "TOF scan period (ms)";
            // 
            // Combo_LPIR_PERIOD
            // 
            this.Combo_LPIR_PERIOD.DisplayMember = "0";
            this.Combo_LPIR_PERIOD.FormattingEnabled = true;
            this.Combo_LPIR_PERIOD.Items.AddRange(new object[] {
            "OFF",
            "50",
            "100",
            "200",
            "250",
            "330",
            "500",
            "750"});
            this.Combo_LPIR_PERIOD.Location = new System.Drawing.Point(10, 93);
            this.Combo_LPIR_PERIOD.Margin = new System.Windows.Forms.Padding(2);
            this.Combo_LPIR_PERIOD.Name = "Combo_LPIR_PERIOD";
            this.Combo_LPIR_PERIOD.Size = new System.Drawing.Size(70, 21);
            this.Combo_LPIR_PERIOD.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "LPIR period (ms)";
            // 
            // CleanLED_BOX
            // 
            this.CleanLED_BOX.AutoSize = true;
            this.CleanLED_BOX.Checked = true;
            this.CleanLED_BOX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CleanLED_BOX.Location = new System.Drawing.Point(9, 334);
            this.CleanLED_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.CleanLED_BOX.Name = "CleanLED_BOX";
            this.CleanLED_BOX.Size = new System.Drawing.Size(77, 17);
            this.CleanLED_BOX.TabIndex = 29;
            this.CleanLED_BOX.Text = "Clean LED";
            this.CleanLED_BOX.UseVisualStyleBackColor = true;
            // 
            // OPT2_STATE_BOX
            // 
            this.OPT2_STATE_BOX.AutoSize = true;
            this.OPT2_STATE_BOX.Location = new System.Drawing.Point(9, 354);
            this.OPT2_STATE_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.OPT2_STATE_BOX.Name = "OPT2_STATE_BOX";
            this.OPT2_STATE_BOX.Size = new System.Drawing.Size(99, 17);
            this.OPT2_STATE_BOX.TabIndex = 30;
            this.OPT2_STATE_BOX.Text = "Option 2 Power";
            this.OPT2_STATE_BOX.UseVisualStyleBackColor = true;
            // 
            // OPT3_STATE_BOX
            // 
            this.OPT3_STATE_BOX.AutoSize = true;
            this.OPT3_STATE_BOX.Location = new System.Drawing.Point(9, 375);
            this.OPT3_STATE_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.OPT3_STATE_BOX.Name = "OPT3_STATE_BOX";
            this.OPT3_STATE_BOX.Size = new System.Drawing.Size(99, 17);
            this.OPT3_STATE_BOX.TabIndex = 31;
            this.OPT3_STATE_BOX.Text = "Option 3 Power";
            this.OPT3_STATE_BOX.UseVisualStyleBackColor = true;
            // 
            // Combo_TxDuration
            // 
            this.Combo_TxDuration.DisplayMember = "Medium (1.5)";
            this.Combo_TxDuration.FormattingEnabled = true;
            this.Combo_TxDuration.Items.AddRange(new object[] {
            "Short (1)",
            "Medium (1.5)",
            "Long (2)",
            "Very Long (3)"});
            this.Combo_TxDuration.Location = new System.Drawing.Point(9, 126);
            this.Combo_TxDuration.Name = "Combo_TxDuration";
            this.Combo_TxDuration.Size = new System.Drawing.Size(71, 21);
            this.Combo_TxDuration.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Transmission Duration (sec)";
            // 
            // Combo_BeaconDuration
            // 
            this.Combo_BeaconDuration.DisplayMember = "Short (1)";
            this.Combo_BeaconDuration.FormattingEnabled = true;
            this.Combo_BeaconDuration.Items.AddRange(new object[] {
            "Short (1)",
            "Medium (1.5)",
            "Long (2)",
            "Very Long (3)"});
            this.Combo_BeaconDuration.Location = new System.Drawing.Point(9, 154);
            this.Combo_BeaconDuration.Name = "Combo_BeaconDuration";
            this.Combo_BeaconDuration.Size = new System.Drawing.Size(72, 21);
            this.Combo_BeaconDuration.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Beacon Duration (Sec)";
            // 
            // IntervalAlarm_BOX
            // 
            this.IntervalAlarm_BOX.AutoSize = true;
            this.IntervalAlarm_BOX.Location = new System.Drawing.Point(9, 395);
            this.IntervalAlarm_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.IntervalAlarm_BOX.Name = "IntervalAlarm_BOX";
            this.IntervalAlarm_BOX.Size = new System.Drawing.Size(90, 17);
            this.IntervalAlarm_BOX.TabIndex = 41;
            this.IntervalAlarm_BOX.Text = "Interval Alarm";
            this.IntervalAlarm_BOX.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Version";
            // 
            // txt_DevVersion
            // 
            this.txt_DevVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DevVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_DevVersion.Location = new System.Drawing.Point(252, 19);
            this.txt_DevVersion.MaxLength = 100;
            this.txt_DevVersion.Name = "txt_DevVersion";
            this.txt_DevVersion.ReadOnly = true;
            this.txt_DevVersion.Size = new System.Drawing.Size(47, 21);
            this.txt_DevVersion.TabIndex = 44;
            this.txt_DevVersion.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(422, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 15);
            this.label14.TabIndex = 48;
            this.label14.Text = "Serial Port Number";
            // 
            // Combo_PortList
            // 
            this.Combo_PortList.FormattingEnabled = true;
            this.Combo_PortList.Items.AddRange(new object[] {
            "Short (1)",
            "Medium (1.5)",
            "Long (2)",
            "Very Long (3)"});
            this.Combo_PortList.Location = new System.Drawing.Point(536, 6);
            this.Combo_PortList.Name = "Combo_PortList";
            this.Combo_PortList.Size = new System.Drawing.Size(78, 21);
            this.Combo_PortList.TabIndex = 51;
            // 
            // Numeric_Erros
            // 
            this.Numeric_Erros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Erros.ForeColor = System.Drawing.Color.Black;
            this.Numeric_Erros.Location = new System.Drawing.Point(252, 71);
            this.Numeric_Erros.MaxLength = 100;
            this.Numeric_Erros.Name = "Numeric_Erros";
            this.Numeric_Erros.ReadOnly = true;
            this.Numeric_Erros.Size = new System.Drawing.Size(47, 21);
            this.Numeric_Erros.TabIndex = 55;
            this.Numeric_Erros.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Device Errors";
            // 
            // numeric_DevID
            // 
            this.numeric_DevID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_DevID.Hexadecimal = true;
            this.numeric_DevID.Location = new System.Drawing.Point(10, 249);
            this.numeric_DevID.Maximum = new decimal(new int[] {
            28671,
            0,
            0,
            0});
            this.numeric_DevID.Name = "numeric_DevID";
            this.numeric_DevID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numeric_DevID.Size = new System.Drawing.Size(70, 26);
            this.numeric_DevID.TabIndex = 64;
            this.numeric_DevID.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 418);
            this.Controls.Add(this.numeric_DevID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numeric_Erros);
            this.Controls.Add(this.Combo_PortList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_DevVersion);
            this.Controls.Add(this.IntervalAlarm_BOX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Combo_BeaconDuration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Combo_TxDuration);
            this.Controls.Add(this.OPT3_STATE_BOX);
            this.Controls.Add(this.OPT2_STATE_BOX);
            this.Controls.Add(this.CleanLED_BOX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Combo_LPIR_PERIOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Combo_TOF_PERIOD);
            this.Controls.Add(this.DevicePower_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeric_SampleTime);
            this.Controls.Add(this.Connect_Device);
            this.Controls.Add(this.Btn_Disconnect);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Download_Memory);
            this.Controls.Add(this.Btn_Erase_Memory);
            this.Controls.Add(this.label1);
            this.Name = "Form_Settings";
            this.Text = "URESP Configuration Interface";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SampleTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DevID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Erase_Memory;
        private System.Windows.Forms.Button Btn_Download_Memory;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.Button Connect_Device;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox DevicePower_Box;
        private System.Windows.Forms.ComboBox Combo_TOF_PERIOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Combo_LPIR_PERIOD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CleanLED_BOX;
        private System.Windows.Forms.CheckBox OPT2_STATE_BOX;
        private System.Windows.Forms.CheckBox OPT3_STATE_BOX;
        private System.Windows.Forms.ComboBox Combo_TxDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Combo_BeaconDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox IntervalAlarm_BOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DevVersion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Combo_PortList;
        private System.Windows.Forms.TextBox Numeric_Erros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_SampleTime;
        private System.Windows.Forms.NumericUpDown numeric_DevID;
    }
}