namespace PS3DiscordRPCApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            SaveConfigs();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            DiscordRPC.Shutdown();
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ps3AddressTextBox = new System.Windows.Forms.TextBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.ps3AddressLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GameIconImageBox = new System.Windows.Forms.PictureBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.RSXTempLabel = new System.Windows.Forms.Label();
            this.CPUTempLabel = new System.Windows.Forms.Label();
            this.PowerOffBtn = new System.Windows.Forms.Button();
            this.RestartPS3Btn = new System.Windows.Forms.Button();
            this.startupTestCB = new System.Windows.Forms.CheckBox();
            this.startupConnectCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIconImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ps3AddressTextBox
            // 
            this.ps3AddressTextBox.Location = new System.Drawing.Point(91, 6);
            this.ps3AddressTextBox.Name = "ps3AddressTextBox";
            this.ps3AddressTextBox.Size = new System.Drawing.Size(204, 20);
            this.ps3AddressTextBox.TabIndex = 0;
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(407, 6);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(108, 23);
            this.testConnectionButton.TabIndex = 1;
            this.testConnectionButton.Text = "Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // ps3AddressLabel
            // 
            this.ps3AddressLabel.AutoSize = true;
            this.ps3AddressLabel.Location = new System.Drawing.Point(12, 9);
            this.ps3AddressLabel.Name = "ps3AddressLabel";
            this.ps3AddressLabel.Size = new System.Drawing.Size(70, 13);
            this.ps3AddressLabel.TabIndex = 2;
            this.ps3AddressLabel.Text = "PS3 LAN IP: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 35);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status: --";
            // 
            // connectBtn
            // 
            this.connectBtn.Enabled = false;
            this.connectBtn.Location = new System.Drawing.Point(407, 35);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(108, 23);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameIconImageBox);
            this.groupBox1.Controls.Add(this.GameLabel);
            this.groupBox1.Controls.Add(this.RSXTempLabel);
            this.groupBox1.Controls.Add(this.CPUTempLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PS3 Info";
            // 
            // GameIconImageBox
            // 
            this.GameIconImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameIconImageBox.Location = new System.Drawing.Point(309, 16);
            this.GameIconImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.GameIconImageBox.MaximumSize = new System.Drawing.Size(185, 88);
            this.GameIconImageBox.Name = "GameIconImageBox";
            this.GameIconImageBox.Size = new System.Drawing.Size(185, 88);
            this.GameIconImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameIconImageBox.TabIndex = 3;
            this.GameIconImageBox.TabStop = false;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(7, 74);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(75, 13);
            this.GameLabel.TabIndex = 2;
            this.GameLabel.Text = "Current Game:";
            // 
            // RSXTempLabel
            // 
            this.RSXTempLabel.AutoSize = true;
            this.RSXTempLabel.Location = new System.Drawing.Point(7, 47);
            this.RSXTempLabel.Name = "RSXTempLabel";
            this.RSXTempLabel.Size = new System.Drawing.Size(32, 13);
            this.RSXTempLabel.TabIndex = 1;
            this.RSXTempLabel.Text = "RSX:";
            // 
            // CPUTempLabel
            // 
            this.CPUTempLabel.AutoSize = true;
            this.CPUTempLabel.Location = new System.Drawing.Point(7, 20);
            this.CPUTempLabel.Name = "CPUTempLabel";
            this.CPUTempLabel.Size = new System.Drawing.Size(32, 13);
            this.CPUTempLabel.TabIndex = 0;
            this.CPUTempLabel.Text = "CPU:";
            // 
            // PowerOffBtn
            // 
            this.PowerOffBtn.Location = new System.Drawing.Point(299, 64);
            this.PowerOffBtn.Name = "PowerOffBtn";
            this.PowerOffBtn.Size = new System.Drawing.Size(100, 23);
            this.PowerOffBtn.TabIndex = 6;
            this.PowerOffBtn.Text = "Shutdown PS3";
            this.PowerOffBtn.UseVisualStyleBackColor = true;
            this.PowerOffBtn.Click += new System.EventHandler(this.PowerOffBtn_Click);
            // 
            // RestartPS3Btn
            // 
            this.RestartPS3Btn.Location = new System.Drawing.Point(407, 64);
            this.RestartPS3Btn.Name = "RestartPS3Btn";
            this.RestartPS3Btn.Size = new System.Drawing.Size(108, 23);
            this.RestartPS3Btn.TabIndex = 7;
            this.RestartPS3Btn.Text = "Restart PS3";
            this.RestartPS3Btn.UseVisualStyleBackColor = true;
            this.RestartPS3Btn.Click += new System.EventHandler(this.RestartPS3Btn_Click);
            // 
            // startupTestCB
            // 
            this.startupTestCB.AutoSize = true;
            this.startupTestCB.Location = new System.Drawing.Point(12, 68);
            this.startupTestCB.Name = "startupTestCB";
            this.startupTestCB.Size = new System.Drawing.Size(156, 17);
            this.startupTestCB.TabIndex = 8;
            this.startupTestCB.Text = "Test Connection on Startup";
            this.startupTestCB.UseVisualStyleBackColor = true;
            // 
            // startupConnectCB
            // 
            this.startupConnectCB.AutoSize = true;
            this.startupConnectCB.Location = new System.Drawing.Point(174, 68);
            this.startupConnectCB.Name = "startupConnectCB";
            this.startupConnectCB.Size = new System.Drawing.Size(118, 17);
            this.startupConnectCB.TabIndex = 9;
            this.startupConnectCB.Text = "Connect on Startup";
            this.startupConnectCB.UseVisualStyleBackColor = true;
            this.startupConnectCB.CheckedChanged += new System.EventHandler(this.startupConnectCB_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 228);
            this.Controls.Add(this.startupConnectCB);
            this.Controls.Add(this.startupTestCB);
            this.Controls.Add(this.RestartPS3Btn);
            this.Controls.Add(this.PowerOffBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ps3AddressLabel);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.ps3AddressTextBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PlayStation®3 Discord Rich Presence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIconImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ps3AddressTextBox;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Label ps3AddressLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PowerOffBtn;
        private System.Windows.Forms.Button RestartPS3Btn;
        public System.Windows.Forms.Label CPUTempLabel;
        public System.Windows.Forms.Label RSXTempLabel;
        public System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.PictureBox GameIconImageBox;
        private System.Windows.Forms.CheckBox startupTestCB;
        private System.Windows.Forms.CheckBox startupConnectCB;
    }
}

