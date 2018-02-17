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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            DiscordController.Shutdown();
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GameIconImageBox = new System.Windows.Forms.PictureBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.RSXTempLabel = new System.Windows.Forms.Label();
            this.CPUTempLabel = new System.Windows.Forms.Label();
            this.PowerOffBtn = new System.Windows.Forms.Button();
            this.RestartPS3Btn = new System.Windows.Forms.Button();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShareBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIconImageBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(37, 21);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(126, 23);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameIconImageBox);
            this.groupBox1.Controls.Add(this.GameLabel);
            this.groupBox1.Controls.Add(this.RSXTempLabel);
            this.groupBox1.Controls.Add(this.CPUTempLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PS3 Info";
            // 
            // GameIconImageBox
            // 
            this.GameIconImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameIconImageBox.Location = new System.Drawing.Point(72, 118);
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
            this.GameLabel.Location = new System.Drawing.Point(9, 75);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(75, 13);
            this.GameLabel.TabIndex = 2;
            this.GameLabel.Text = "Current Game:";
            // 
            // RSXTempLabel
            // 
            this.RSXTempLabel.AutoSize = true;
            this.RSXTempLabel.Location = new System.Drawing.Point(9, 48);
            this.RSXTempLabel.Name = "RSXTempLabel";
            this.RSXTempLabel.Size = new System.Drawing.Size(32, 13);
            this.RSXTempLabel.TabIndex = 1;
            this.RSXTempLabel.Text = "RSX:";
            // 
            // CPUTempLabel
            // 
            this.CPUTempLabel.AutoSize = true;
            this.CPUTempLabel.Location = new System.Drawing.Point(9, 21);
            this.CPUTempLabel.Name = "CPUTempLabel";
            this.CPUTempLabel.Size = new System.Drawing.Size(32, 13);
            this.CPUTempLabel.TabIndex = 0;
            this.CPUTempLabel.Text = "CPU:";
            // 
            // PowerOffBtn
            // 
            this.PowerOffBtn.Location = new System.Drawing.Point(194, 50);
            this.PowerOffBtn.Name = "PowerOffBtn";
            this.PowerOffBtn.Size = new System.Drawing.Size(126, 23);
            this.PowerOffBtn.TabIndex = 5;
            this.PowerOffBtn.Text = "Shutdown PS3";
            this.PowerOffBtn.UseVisualStyleBackColor = true;
            this.PowerOffBtn.Click += new System.EventHandler(this.PowerOffBtn_Click);
            // 
            // RestartPS3Btn
            // 
            this.RestartPS3Btn.Location = new System.Drawing.Point(194, 21);
            this.RestartPS3Btn.Name = "RestartPS3Btn";
            this.RestartPS3Btn.Size = new System.Drawing.Size(126, 23);
            this.RestartPS3Btn.TabIndex = 4;
            this.RestartPS3Btn.Text = "Restart PS3";
            this.RestartPS3Btn.UseVisualStyleBackColor = true;
            this.RestartPS3Btn.Click += new System.EventHandler(this.RestartPS3Btn_Click);
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Location = new System.Drawing.Point(194, 79);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(126, 23);
            this.ConfigBtn.TabIndex = 6;
            this.ConfigBtn.Text = "Configuration";
            this.ConfigBtn.UseVisualStyleBackColor = true;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(350, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.Text = "Status:";
            // 
            // ShareBtn
            // 
            this.ShareBtn.Location = new System.Drawing.Point(38, 50);
            this.ShareBtn.Name = "ShareBtn";
            this.ShareBtn.Size = new System.Drawing.Size(126, 23);
            this.ShareBtn.TabIndex = 2;
            this.ShareBtn.Text = "Share Current Game";
            this.ShareBtn.UseVisualStyleBackColor = true;
            this.ShareBtn.Click += new System.EventHandler(this.ShareBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(38, 79);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(126, 23);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 17);
            this.StatusLabel.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 377);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.ShareBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ConfigBtn);
            this.Controls.Add(this.RestartPS3Btn);
            this.Controls.Add(this.PowerOffBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConnectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayStation®3 Discord Rich Presence";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIconImageBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PowerOffBtn;
        private System.Windows.Forms.Button RestartPS3Btn;
        public System.Windows.Forms.Label CPUTempLabel;
        public System.Windows.Forms.Label RSXTempLabel;
        public System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.PictureBox GameIconImageBox;
        private System.Windows.Forms.Button ConfigBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label1;
        private System.Windows.Forms.Button ShareBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

