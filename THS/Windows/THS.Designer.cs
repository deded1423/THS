using System.Windows.Forms;

namespace THS.Windows
{
    partial class THS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonConfig = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.checkBoxTCP = new System.Windows.Forms.CheckBox();
            this.buttonStartTCP = new System.Windows.Forms.Button();
            this.checkBoxHs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.Location = new System.Drawing.Point(119, 6);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfig.TabIndex = 0;
            this.ButtonConfig.Text = "Config";
            this.ButtonConfig.UseVisualStyleBackColor = true;
            this.ButtonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(106, 35);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(88, 74);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // checkBoxTCP
            // 
            this.checkBoxTCP.AutoSize = true;
            this.checkBoxTCP.Location = new System.Drawing.Point(12, 12);
            this.checkBoxTCP.Name = "checkBoxTCP";
            this.checkBoxTCP.Size = new System.Drawing.Size(101, 17);
            this.checkBoxTCP.TabIndex = 14;
            this.checkBoxTCP.Text = "IRC (Not twitch)";
            this.checkBoxTCP.UseVisualStyleBackColor = true;
            // 
            // buttonStartTCP
            // 
            this.buttonStartTCP.Location = new System.Drawing.Point(12, 35);
            this.buttonStartTCP.Name = "buttonStartTCP";
            this.buttonStartTCP.Size = new System.Drawing.Size(88, 74);
            this.buttonStartTCP.TabIndex = 16;
            this.buttonStartTCP.Text = "Start Tcp";
            this.buttonStartTCP.UseVisualStyleBackColor = true;
            this.buttonStartTCP.Click += new System.EventHandler(this.buttonStartTCP_Click);
            // 
            // checkBoxHs
            // 
            this.checkBoxHs.AutoSize = true;
            this.checkBoxHs.Location = new System.Drawing.Point(12, 115);
            this.checkBoxHs.Name = "checkBoxHs";
            this.checkBoxHs.Size = new System.Drawing.Size(56, 17);
            this.checkBoxHs.TabIndex = 17;
            this.checkBoxHs.Text = "HS off";
            this.checkBoxHs.UseVisualStyleBackColor = true;
            // 
            // THS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.checkBoxHs);
            this.Controls.Add(this.buttonStartTCP);
            this.Controls.Add(this.checkBoxTCP);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonConfig);
            this.Name = "THS";
            this.Text = "THS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.THS_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button ButtonConfig;
        protected System.Windows.Forms.Button ButtonStart;
        delegate void SetTextCallback(Label label, string text);
        public void SetText(Label label, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (label.InvokeRequired && !stopinput)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] {label, text });
            }
            else
            {
                label.Text = text;
            }
        }
        private CheckBox checkBoxTCP;
        protected Button buttonStartTCP;
        private CheckBox checkBoxHs;
    }
}

