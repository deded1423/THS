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
            this.LabelIP = new System.Windows.Forms.Label();
            this.TextTCPIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TextTCPPort = new System.Windows.Forms.TextBox();
            this.CheckBoxTCP = new System.Windows.Forms.CheckBox();
            this.LabelTCPPort = new System.Windows.Forms.Label();
            this.LabelTCPIP = new System.Windows.Forms.Label();
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
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(12, 93);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(56, 13);
            this.LabelIP.TabIndex = 9;
            this.LabelIP.Text = "Send TCP";
            // 
            // TextTCPIP
            // 
            this.TextTCPIP.Location = new System.Drawing.Point(129, 90);
            this.TextTCPIP.Name = "TextTCPIP";
            this.TextTCPIP.Size = new System.Drawing.Size(105, 20);
            this.TextTCPIP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "aaaaaaaa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 10;
            // 
            // TextTCPPort
            // 
            this.TextTCPPort.Location = new System.Drawing.Point(275, 90);
            this.TextTCPPort.Name = "TextTCPPort";
            this.TextTCPPort.Size = new System.Drawing.Size(42, 20);
            this.TextTCPPort.TabIndex = 12;
            // 
            // CheckBoxTCP
            // 
            this.CheckBoxTCP.AutoSize = true;
            this.CheckBoxTCP.Location = new System.Drawing.Point(82, 93);
            this.CheckBoxTCP.Name = "CheckBoxTCP";
            this.CheckBoxTCP.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxTCP.TabIndex = 13;
            this.CheckBoxTCP.UseVisualStyleBackColor = true;
            // 
            // LabelTCPPort
            // 
            this.LabelTCPPort.AutoSize = true;
            this.LabelTCPPort.Location = new System.Drawing.Point(240, 93);
            this.LabelTCPPort.Name = "LabelTCPPort";
            this.LabelTCPPort.Size = new System.Drawing.Size(29, 13);
            this.LabelTCPPort.TabIndex = 14;
            this.LabelTCPPort.Text = "Port:";
            // 
            // LabelTCPIP
            // 
            this.LabelTCPIP.AutoSize = true;
            this.LabelTCPIP.Location = new System.Drawing.Point(103, 93);
            this.LabelTCPIP.Name = "LabelTCPIP";
            this.LabelTCPIP.Size = new System.Drawing.Size(20, 13);
            this.LabelTCPIP.TabIndex = 15;
            this.LabelTCPIP.Text = "IP:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 185);
            this.Controls.Add(this.LabelTCPIP);
            this.Controls.Add(this.LabelTCPPort);
            this.Controls.Add(this.CheckBoxTCP);
            this.Controls.Add(this.TextTCPPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.TextTCPIP);
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
        public System.Windows.Forms.Label LabelTCPIP;
        protected System.Windows.Forms.Button ButtonConfigAccept;
        protected System.Windows.Forms.Button ButtonConfigCancel;
        protected System.Windows.Forms.TextBox TextHearthstonePath;
        protected System.Windows.Forms.Label LabelConfig;
        protected System.Windows.Forms.Label LabelTwitchLoginName;
        protected System.Windows.Forms.TextBox TextTwitchLoginName;
        protected System.Windows.Forms.Label LabelTwitchLoginOauth;
        protected System.Windows.Forms.TextBox TextTwitchLoginOauth;
        protected System.Windows.Forms.Label LabelIP;
        protected System.Windows.Forms.TextBox TextTCPIP;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox TextTCPPort;
        protected System.Windows.Forms.Label LabelTCPPort;
        protected System.Windows.Forms.CheckBox CheckBoxTCP;
    }
}