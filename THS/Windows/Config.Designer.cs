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
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 185);
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
        protected System.Windows.Forms.Button ButtonConfigAccept;
        protected System.Windows.Forms.Button ButtonConfigCancel;
        protected System.Windows.Forms.TextBox TextHearthstonePath;
        protected System.Windows.Forms.Label LabelConfig;
        protected System.Windows.Forms.Label LabelTwitchLoginName;
        protected System.Windows.Forms.TextBox TextTwitchLoginName;
        protected System.Windows.Forms.Label LabelTwitchLoginOauth;
        protected System.Windows.Forms.TextBox TextTwitchLoginOauth;
    }
}