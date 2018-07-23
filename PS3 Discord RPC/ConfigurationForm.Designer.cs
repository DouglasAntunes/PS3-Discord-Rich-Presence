namespace PS3DiscordRPCApp
{
    partial class ConfigurationForm
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
            this.DiscordAppIdLabel = new System.Windows.Forms.LinkLabel();
            this.SaveAndCloseBtn = new System.Windows.Forms.Button();
            this.ps3AddressLabel = new System.Windows.Forms.Label();
            this.TestConnectionBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ps3Status = new System.Windows.Forms.Label();
            this.PS3AddressTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShareGameOnStartupCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.StartupTestCB = new System.Windows.Forms.CheckBox();
            this.StartupConnectCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DiscordAppIDTextBox = new System.Windows.Forms.TextBox();
            this.DiscordAppIDDefaultCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscordAppIdLabel
            // 
            this.DiscordAppIdLabel.AutoSize = true;
            this.DiscordAppIdLabel.Location = new System.Drawing.Point(10, 22);
            this.DiscordAppIdLabel.Name = "DiscordAppIdLabel";
            this.DiscordAppIdLabel.Size = new System.Drawing.Size(106, 13);
            this.DiscordAppIdLabel.TabIndex = 8;
            this.DiscordAppIdLabel.TabStop = true;
            this.DiscordAppIdLabel.Text = "Discord Aplication ID";
            this.DiscordAppIdLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordAppIdLabel_LinkClicked);
            // 
            // SaveAndCloseBtn
            // 
            this.SaveAndCloseBtn.Location = new System.Drawing.Point(319, 242);
            this.SaveAndCloseBtn.Name = "SaveAndCloseBtn";
            this.SaveAndCloseBtn.Size = new System.Drawing.Size(172, 23);
            this.SaveAndCloseBtn.TabIndex = 11;
            this.SaveAndCloseBtn.Text = "Save and Close this Window";
            this.SaveAndCloseBtn.UseVisualStyleBackColor = true;
            this.SaveAndCloseBtn.Click += new System.EventHandler(this.SaveAndCloseBtn_Click);
            // 
            // ps3AddressLabel
            // 
            this.ps3AddressLabel.AutoSize = true;
            this.ps3AddressLabel.Location = new System.Drawing.Point(11, 22);
            this.ps3AddressLabel.Name = "ps3AddressLabel";
            this.ps3AddressLabel.Size = new System.Drawing.Size(64, 13);
            this.ps3AddressLabel.TabIndex = 5;
            this.ps3AddressLabel.Text = "PS3 LAN IP";
            // 
            // TestConnectionBtn
            // 
            this.TestConnectionBtn.Location = new System.Drawing.Point(194, 17);
            this.TestConnectionBtn.Name = "TestConnectionBtn";
            this.TestConnectionBtn.Size = new System.Drawing.Size(108, 23);
            this.TestConnectionBtn.TabIndex = 2;
            this.TestConnectionBtn.Text = "Test Connection";
            this.TestConnectionBtn.UseVisualStyleBackColor = true;
            this.TestConnectionBtn.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ps3Status);
            this.groupBox1.Controls.Add(this.PS3AddressTextBox);
            this.groupBox1.Controls.Add(this.TestConnectionBtn);
            this.groupBox1.Controls.Add(this.ps3AddressLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PS3";
            // 
            // ps3Status
            // 
            this.ps3Status.AutoSize = true;
            this.ps3Status.Location = new System.Drawing.Point(314, 22);
            this.ps3Status.Name = "ps3Status";
            this.ps3Status.Size = new System.Drawing.Size(0, 13);
            this.ps3Status.TabIndex = 13;
            // 
            // PS3AddressTextBox
            // 
            this.PS3AddressTextBox.Location = new System.Drawing.Point(81, 19);
            this.PS3AddressTextBox.MaxLength = 15;
            this.PS3AddressTextBox.Name = "PS3AddressTextBox";
            this.PS3AddressTextBox.Size = new System.Drawing.Size(107, 20);
            this.PS3AddressTextBox.TabIndex = 1;
            this.PS3AddressTextBox.Text = global::PS3DiscordRPCApp.Properties.Settings.Default.PS3_IP;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShareGameOnStartupCB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FahrenheitRB);
            this.groupBox2.Controls.Add(this.CelsiusRB);
            this.groupBox2.Controls.Add(this.StartupTestCB);
            this.groupBox2.Controls.Add(this.StartupConnectCB);
            this.groupBox2.Location = new System.Drawing.Point(15, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 75);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program";
            // 
            // ShareGameOnStartupCB
            // 
            this.ShareGameOnStartupCB.AutoSize = true;
            this.ShareGameOnStartupCB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.ShareOnStartup;
            this.ShareGameOnStartupCB.Location = new System.Drawing.Point(14, 42);
            this.ShareGameOnStartupCB.Name = "ShareGameOnStartupCB";
            this.ShareGameOnStartupCB.Size = new System.Drawing.Size(180, 17);
            this.ShareGameOnStartupCB.TabIndex = 7;
            this.ShareGameOnStartupCB.Text = "Share Current Game on Connect";
            this.ShareGameOnStartupCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temperature: ";
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.TempF;
            this.FahrenheitRB.Location = new System.Drawing.Point(427, 18);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(35, 17);
            this.FahrenheitRB.TabIndex = 6;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "°F";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.TempC;
            this.CelsiusRB.Location = new System.Drawing.Point(385, 18);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(36, 17);
            this.CelsiusRB.TabIndex = 5;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "°C";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // StartupTestCB
            // 
            this.StartupTestCB.AutoSize = true;
            this.StartupTestCB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.TestConnectionOnStartup;
            this.StartupTestCB.Location = new System.Drawing.Point(14, 19);
            this.StartupTestCB.Name = "StartupTestCB";
            this.StartupTestCB.Size = new System.Drawing.Size(156, 17);
            this.StartupTestCB.TabIndex = 3;
            this.StartupTestCB.Text = "Test Connection on Startup";
            this.StartupTestCB.UseVisualStyleBackColor = true;
            // 
            // StartupConnectCB
            // 
            this.StartupConnectCB.AutoSize = true;
            this.StartupConnectCB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.ConnectOnStartup;
            this.StartupConnectCB.Location = new System.Drawing.Point(176, 19);
            this.StartupConnectCB.Name = "StartupConnectCB";
            this.StartupConnectCB.Size = new System.Drawing.Size(118, 17);
            this.StartupConnectCB.TabIndex = 4;
            this.StartupConnectCB.Text = "Connect on Startup";
            this.StartupConnectCB.UseVisualStyleBackColor = true;
            this.StartupConnectCB.CheckedChanged += new System.EventHandler(this.StartupConnectCB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DiscordAppIDTextBox);
            this.groupBox3.Controls.Add(this.DiscordAppIdLabel);
            this.groupBox3.Controls.Add(this.DiscordAppIDDefaultCB);
            this.groupBox3.Location = new System.Drawing.Point(15, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 51);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord Rich Presence Options";
            // 
            // DiscordAppIDTextBox
            // 
           this.DiscordAppIDTextBox.Enabled = false;
            this.DiscordAppIDTextBox.Location = new System.Drawing.Point(122, 19);
            this.DiscordAppIDTextBox.Name = "DiscordAppIDTextBox";
            this.DiscordAppIDTextBox.Size = new System.Drawing.Size(257, 20);
            this.DiscordAppIDTextBox.TabIndex = 9;
            this.DiscordAppIDTextBox.Text = global::PS3DiscordRPCApp.Properties.Settings.Default.CustomDiscordAppID;
            // 
            // DiscordAppIDDefaultCB
            // 
            this.DiscordAppIDDefaultCB.AutoSize = true;
            this.DiscordAppIDDefaultCB.Checked = global::PS3DiscordRPCApp.Properties.Settings.Default.UseDefaultDiscordAppID;
            this.DiscordAppIDDefaultCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordAppIDDefaultCB.Location = new System.Drawing.Point(385, 21);
            this.DiscordAppIDDefaultCB.Name = "DiscordAppIDDefaultCB";
            this.DiscordAppIDDefaultCB.Size = new System.Drawing.Size(82, 17);
            this.DiscordAppIDDefaultCB.TabIndex = 10;
            this.DiscordAppIDDefaultCB.Text = "Use Default";
            this.DiscordAppIDDefaultCB.UseVisualStyleBackColor = true;
            this.DiscordAppIDDefaultCB.CheckedChanged += new System.EventHandler(this.DiscordAppIDDefaultCB_CheckedChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 278);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveAndCloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel DiscordAppIdLabel;
        private System.Windows.Forms.Button SaveAndCloseBtn;
        private System.Windows.Forms.CheckBox DiscordAppIDDefaultCB;
        private System.Windows.Forms.TextBox DiscordAppIDTextBox;
        private System.Windows.Forms.Label ps3AddressLabel;
        private System.Windows.Forms.TextBox PS3AddressTextBox;
        private System.Windows.Forms.CheckBox StartupConnectCB;
        private System.Windows.Forms.CheckBox StartupTestCB;
        private System.Windows.Forms.Button TestConnectionBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ps3Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton FahrenheitRB;
        private System.Windows.Forms.RadioButton CelsiusRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShareGameOnStartupCB;
    }
}