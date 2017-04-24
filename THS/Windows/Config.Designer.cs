using THS.Utils;

namespace THS.Windows
{
    partial class Config
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
            this.ButtonConfigAccept = new System.Windows.Forms.Button();
            this.ButtonConfigCancel = new System.Windows.Forms.Button();
            this.TextHearthstonePath = new System.Windows.Forms.TextBox();
            this.LabelConfig = new System.Windows.Forms.Label();
            this.LabelTwitchLoginName = new System.Windows.Forms.Label();
            this.TextTwitchLoginName = new System.Windows.Forms.TextBox();
            this.LabelTwitchLoginOauth = new System.Windows.Forms.Label();
            this.TextTwitchLoginOauth = new System.Windows.Forms.TextBox();
            this.LabelSendIP = new System.Windows.Forms.Label();
            this.TextSendTCPIP = new System.Windows.Forms.TextBox();
            this.TextSendTCPPort = new System.Windows.Forms.TextBox();
            this.CheckBoxSendTCP = new System.Windows.Forms.CheckBox();
            this.LabelSendTCPPort = new System.Windows.Forms.Label();
            this.LabelSendTCPIP = new System.Windows.Forms.Label();
            this.LabelReceiveTCPIP = new System.Windows.Forms.Label();
            this.LabelReceiveTCPPort = new System.Windows.Forms.Label();
            this.CheckBoxReceiveTCP = new System.Windows.Forms.CheckBox();
            this.TextReceiveTCPPort = new System.Windows.Forms.TextBox();
            this.LabelReceiveIP = new System.Windows.Forms.Label();
            this.TextReceiveTCPIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonConfigAccept
            // 
            this.ButtonConfigAccept.Location = new System.Drawing.Point(161, 150);
            this.ButtonConfigAccept.Name = "ButtonConfigAccept";
            this.ButtonConfigAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfigAccept.TabIndex = 0;
            this.ButtonConfigAccept.Text = "Accept";
            this.ButtonConfigAccept.UseVisualStyleBackColor = true;
            this.ButtonConfigAccept.Click += new System.EventHandler(this.ButtonConfigAccept_Click);
            // 
            // ButtonConfigCancel
            // 
            this.ButtonConfigCancel.Location = new System.Drawing.Point(242, 150);
            this.ButtonConfigCancel.Name = "ButtonConfigCancel";
            this.ButtonConfigCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfigCancel.TabIndex = 1;
            this.ButtonConfigCancel.Text = "Cancel";
            this.ButtonConfigCancel.UseVisualStyleBackColor = true;
            this.ButtonConfigCancel.Click += new System.EventHandler(this.ButtonConfigCancel_Click);
            // 
            // TextHearthstonePath
            // 
            this.TextHearthstonePath.Location = new System.Drawing.Point(111, 12);
            this.TextHearthstonePath.Name = "TextHearthstonePath";
            this.TextHearthstonePath.Size = new System.Drawing.Size(206, 20);
            this.TextHearthstonePath.TabIndex = 2;
            // 
            // LabelConfig
            // 
            this.LabelConfig.AutoSize = true;
            this.LabelConfig.Location = new System.Drawing.Point(12, 15);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(93, 13);
            this.LabelConfig.TabIndex = 3;
            this.LabelConfig.Text = "Hearthstone Path:";
            // 
            // LabelTwitchLoginName
            // 
            this.LabelTwitchLoginName.AutoSize = true;
            this.LabelTwitchLoginName.Location = new System.Drawing.Point(12, 41);
            this.LabelTwitchLoginName.Name = "LabelTwitchLoginName";
            this.LabelTwitchLoginName.Size = new System.Drawing.Size(67, 13);
            this.LabelTwitchLoginName.TabIndex = 5;
            this.LabelTwitchLoginName.Text = "Twitch User:";
            // 
            // TextTwitchLoginName
            // 
            this.TextTwitchLoginName.Location = new System.Drawing.Point(111, 38);
            this.TextTwitchLoginName.Name = "TextTwitchLoginName";
            this.TextTwitchLoginName.Size = new System.Drawing.Size(206, 20);
            this.TextTwitchLoginName.TabIndex = 4;
            // 
            // LabelTwitchLoginOauth
            // 
            this.LabelTwitchLoginOauth.AutoSize = true;
            this.LabelTwitchLoginOauth.Location = new System.Drawing.Point(12, 67);
            this.LabelTwitchLoginOauth.Name = "LabelTwitchLoginOauth";
            this.LabelTwitchLoginOauth.Size = new System.Drawing.Size(74, 13);
            this.LabelTwitchLoginOauth.TabIndex = 7;
            this.LabelTwitchLoginOauth.Text = "Twitch Oauth:";
            // 
            // TextTwitchLoginOauth
            // 
            this.TextTwitchLoginOauth.Location = new System.Drawing.Point(111, 64);
            this.TextTwitchLoginOauth.Name = "TextTwitchLoginOauth";
            this.TextTwitchLoginOauth.Size = new System.Drawing.Size(206, 20);
            this.TextTwitchLoginOauth.TabIndex = 6;
            // 
            // LabelSendIP
            // 
            this.LabelSendIP.AutoSize = true;
            this.LabelSendIP.Location = new System.Drawing.Point(12, 93);
            this.LabelSendIP.Name = "LabelSendIP";
            this.LabelSendIP.Size = new System.Drawing.Size(56, 13);
            this.LabelSendIP.TabIndex = 9;
            this.LabelSendIP.Text = "Send TCP";
            // 
            // TextSendTCPIP
            // 
            this.TextSendTCPIP.Location = new System.Drawing.Point(129, 90);
            this.TextSendTCPIP.Name = "TextSendTCPIP";
            this.TextSendTCPIP.Size = new System.Drawing.Size(105, 20);
            this.TextSendTCPIP.TabIndex = 8;
            // 
            // TextSendTCPPort
            // 
            this.TextSendTCPPort.Location = new System.Drawing.Point(275, 90);
            this.TextSendTCPPort.Name = "TextSendTCPPort";
            this.TextSendTCPPort.Size = new System.Drawing.Size(42, 20);
            this.TextSendTCPPort.TabIndex = 12;
            // 
            // CheckBoxSendTCP
            // 
            this.CheckBoxSendTCP.AutoSize = true;
            this.CheckBoxSendTCP.Location = new System.Drawing.Point(82, 93);
            this.CheckBoxSendTCP.Name = "CheckBoxSendTCP";
            this.CheckBoxSendTCP.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxSendTCP.TabIndex = 13;
            this.CheckBoxSendTCP.UseVisualStyleBackColor = true;
            this.CheckBoxSendTCP.Click += new System.EventHandler(this.CheckBoxSendTCP_CheckedChanged);
            // 
            // LabelSendTCPPort
            // 
            this.LabelSendTCPPort.AutoSize = true;
            this.LabelSendTCPPort.Location = new System.Drawing.Point(240, 93);
            this.LabelSendTCPPort.Name = "LabelSendTCPPort";
            this.LabelSendTCPPort.Size = new System.Drawing.Size(29, 13);
            this.LabelSendTCPPort.TabIndex = 14;
            this.LabelSendTCPPort.Text = "Port:";
            // 
            // LabelSendTCPIP
            // 
            this.LabelSendTCPIP.AutoSize = true;
            this.LabelSendTCPIP.Location = new System.Drawing.Point(103, 93);
            this.LabelSendTCPIP.Name = "LabelSendTCPIP";
            this.LabelSendTCPIP.Size = new System.Drawing.Size(20, 13);
            this.LabelSendTCPIP.TabIndex = 15;
            this.LabelSendTCPIP.Text = "IP:";
            // 
            // LabelReceiveTCPIP
            // 
            this.LabelReceiveTCPIP.AutoSize = true;
            this.LabelReceiveTCPIP.Location = new System.Drawing.Point(103, 119);
            this.LabelReceiveTCPIP.Name = "LabelReceiveTCPIP";
            this.LabelReceiveTCPIP.Size = new System.Drawing.Size(20, 13);
            this.LabelReceiveTCPIP.TabIndex = 21;
            this.LabelReceiveTCPIP.Text = "IP:";
            // 
            // LabelReceiveTCPPort
            // 
            this.LabelReceiveTCPPort.AutoSize = true;
            this.LabelReceiveTCPPort.Location = new System.Drawing.Point(240, 119);
            this.LabelReceiveTCPPort.Name = "LabelReceiveTCPPort";
            this.LabelReceiveTCPPort.Size = new System.Drawing.Size(29, 13);
            this.LabelReceiveTCPPort.TabIndex = 20;
            this.LabelReceiveTCPPort.Text = "Port:";
            // 
            // CheckBoxReceiveTCP
            // 
            this.CheckBoxReceiveTCP.AutoSize = true;
            this.CheckBoxReceiveTCP.Location = new System.Drawing.Point(82, 119);
            this.CheckBoxReceiveTCP.Name = "CheckBoxReceiveTCP";
            this.CheckBoxReceiveTCP.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxReceiveTCP.TabIndex = 19;
            this.CheckBoxReceiveTCP.UseVisualStyleBackColor = true;
            this.CheckBoxReceiveTCP.Click += new System.EventHandler(this.CheckBoxReceiveTCP_CheckedChanged);
            // 
            // TextReceiveTCPPort
            // 
            this.TextReceiveTCPPort.Location = new System.Drawing.Point(275, 116);
            this.TextReceiveTCPPort.Name = "TextReceiveTCPPort";
            this.TextReceiveTCPPort.Size = new System.Drawing.Size(42, 20);
            this.TextReceiveTCPPort.TabIndex = 18;
            // 
            // LabelReceiveIP
            // 
            this.LabelReceiveIP.AutoSize = true;
            this.LabelReceiveIP.Location = new System.Drawing.Point(12, 119);
            this.LabelReceiveIP.Name = "LabelReceiveIP";
            this.LabelReceiveIP.Size = new System.Drawing.Size(71, 13);
            this.LabelReceiveIP.TabIndex = 17;
            this.LabelReceiveIP.Text = "Receive TCP";
            // 
            // TextReceiveTCPIP
            // 
            this.TextReceiveTCPIP.Location = new System.Drawing.Point(129, 116);
            this.TextReceiveTCPIP.Name = "TextReceiveTCPIP";
            this.TextReceiveTCPIP.Size = new System.Drawing.Size(105, 20);
            this.TextReceiveTCPIP.TabIndex = 16;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 185);
            this.Controls.Add(this.LabelReceiveTCPIP);
            this.Controls.Add(this.LabelReceiveTCPPort);
            this.Controls.Add(this.CheckBoxReceiveTCP);
            this.Controls.Add(this.TextReceiveTCPPort);
            this.Controls.Add(this.LabelReceiveIP);
            this.Controls.Add(this.TextReceiveTCPIP);
            this.Controls.Add(this.LabelSendTCPIP);
            this.Controls.Add(this.LabelSendTCPPort);
            this.Controls.Add(this.CheckBoxSendTCP);
            this.Controls.Add(this.TextSendTCPPort);
            this.Controls.Add(this.LabelSendIP);
            this.Controls.Add(this.TextSendTCPIP);
            this.Controls.Add(this.LabelTwitchLoginOauth);
            this.Controls.Add(this.TextTwitchLoginOauth);
            this.Controls.Add(this.LabelTwitchLoginName);
            this.Controls.Add(this.TextTwitchLoginName);
            this.Controls.Add(this.LabelConfig);
            this.Controls.Add(this.TextHearthstonePath);
            this.Controls.Add(this.ButtonConfigCancel);
            this.Controls.Add(this.ButtonConfigAccept);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LabelSendTCPIP;
        protected System.Windows.Forms.Button ButtonConfigAccept;
        protected System.Windows.Forms.Button ButtonConfigCancel;
        protected System.Windows.Forms.TextBox TextHearthstonePath;
        protected System.Windows.Forms.Label LabelConfig;
        protected System.Windows.Forms.Label LabelTwitchLoginName;
        protected System.Windows.Forms.TextBox TextTwitchLoginName;
        protected System.Windows.Forms.Label LabelTwitchLoginOauth;
        protected System.Windows.Forms.TextBox TextTwitchLoginOauth;
        protected System.Windows.Forms.Label LabelSendIP;
        protected System.Windows.Forms.TextBox TextSendTCPIP;
        protected System.Windows.Forms.TextBox TextSendTCPPort;
        protected System.Windows.Forms.Label LabelSendTCPPort;
        protected System.Windows.Forms.CheckBox CheckBoxSendTCP;
        public System.Windows.Forms.Label LabelReceiveTCPIP;
        protected System.Windows.Forms.Label LabelReceiveTCPPort;
        protected System.Windows.Forms.CheckBox CheckBoxReceiveTCP;
        protected System.Windows.Forms.TextBox TextReceiveTCPPort;
        protected System.Windows.Forms.Label LabelReceiveIP;
        protected System.Windows.Forms.TextBox TextReceiveTCPIP;
    }
}