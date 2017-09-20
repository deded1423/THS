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
            this.LabelScreenOrigin = new System.Windows.Forms.Label();
            this.LabelScreenOriginText = new System.Windows.Forms.Label();
            this.LabelScreenSizeText = new System.Windows.Forms.Label();
            this.LabelScreenSize = new System.Windows.Forms.Label();
            this.LabelMouseText = new System.Windows.Forms.Label();
            this.LabelMouse = new System.Windows.Forms.Label();
            this.LabelMouseRelText = new System.Windows.Forms.Label();
            this.LabelMouseRel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.Location = new System.Drawing.Point(256, 128);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfig.TabIndex = 0;
            this.ButtonConfig.Text = "Config";
            this.ButtonConfig.UseVisualStyleBackColor = true;
            this.ButtonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(243, 157);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(88, 74);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelScreenOrigin
            // 
            this.LabelScreenOrigin.AutoSize = true;
            this.LabelScreenOrigin.Location = new System.Drawing.Point(89, 9);
            this.LabelScreenOrigin.Name = "LabelScreenOrigin";
            this.LabelScreenOrigin.Size = new System.Drawing.Size(13, 13);
            this.LabelScreenOrigin.TabIndex = 4;
            this.LabelScreenOrigin.Text = "0";
            // 
            // LabelScreenOriginText
            // 
            this.LabelScreenOriginText.AutoSize = true;
            this.LabelScreenOriginText.Location = new System.Drawing.Point(12, 9);
            this.LabelScreenOriginText.Name = "LabelScreenOriginText";
            this.LabelScreenOriginText.Size = new System.Drawing.Size(71, 13);
            this.LabelScreenOriginText.TabIndex = 5;
            this.LabelScreenOriginText.Text = "Screen Origin";
            // 
            // LabelScreenSizeText
            // 
            this.LabelScreenSizeText.AutoSize = true;
            this.LabelScreenSizeText.Location = new System.Drawing.Point(12, 22);
            this.LabelScreenSizeText.Name = "LabelScreenSizeText";
            this.LabelScreenSizeText.Size = new System.Drawing.Size(64, 13);
            this.LabelScreenSizeText.TabIndex = 7;
            this.LabelScreenSizeText.Text = "Screen Size";
            // 
            // LabelScreenSize
            // 
            this.LabelScreenSize.AutoSize = true;
            this.LabelScreenSize.Location = new System.Drawing.Point(89, 22);
            this.LabelScreenSize.Name = "LabelScreenSize";
            this.LabelScreenSize.Size = new System.Drawing.Size(13, 13);
            this.LabelScreenSize.TabIndex = 6;
            this.LabelScreenSize.Text = "0";
            // 
            // LabelMouseText
            // 
            this.LabelMouseText.AutoSize = true;
            this.LabelMouseText.Location = new System.Drawing.Point(12, 35);
            this.LabelMouseText.Name = "LabelMouseText";
            this.LabelMouseText.Size = new System.Drawing.Size(39, 13);
            this.LabelMouseText.TabIndex = 9;
            this.LabelMouseText.Text = "Mouse";
            // 
            // LabelMouse
            // 
            this.LabelMouse.AutoSize = true;
            this.LabelMouse.Location = new System.Drawing.Point(89, 35);
            this.LabelMouse.Name = "LabelMouse";
            this.LabelMouse.Size = new System.Drawing.Size(13, 13);
            this.LabelMouse.TabIndex = 8;
            this.LabelMouse.Text = "0";
            // 
            // LabelMouseRelText
            // 
            this.LabelMouseRelText.AutoSize = true;
            this.LabelMouseRelText.Location = new System.Drawing.Point(12, 48);
            this.LabelMouseRelText.Name = "LabelMouseRelText";
            this.LabelMouseRelText.Size = new System.Drawing.Size(58, 13);
            this.LabelMouseRelText.TabIndex = 11;
            this.LabelMouseRelText.Text = "Mouse Rel";
            // 
            // LabelMouseRel
            // 
            this.LabelMouseRel.AutoSize = true;
            this.LabelMouseRel.Location = new System.Drawing.Point(89, 48);
            this.LabelMouseRel.Name = "LabelMouseRel";
            this.LabelMouseRel.Size = new System.Drawing.Size(13, 13);
            this.LabelMouseRel.TabIndex = 10;
            this.LabelMouseRel.Text = "0";
            // 
            // THS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.LabelMouseRelText);
            this.Controls.Add(this.LabelMouseRel);
            this.Controls.Add(this.LabelMouseText);
            this.Controls.Add(this.LabelMouse);
            this.Controls.Add(this.LabelScreenSizeText);
            this.Controls.Add(this.LabelScreenSize);
            this.Controls.Add(this.LabelScreenOriginText);
            this.Controls.Add(this.LabelScreenOrigin);
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
        public System.Windows.Forms.Label LabelScreenOrigin;
        private System.Windows.Forms.Label LabelScreenOriginText;
        delegate void SetTextCallback(Label label, string text);
        public void SetText(Label label, string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] {label, text });
            }
            else
            {
                label.Text = text;
            }
        }

        private Label LabelScreenSizeText;
        public Label LabelScreenSize;
        private Label LabelMouseText;
        public Label LabelMouse;
        private Label LabelMouseRelText;
        public Label LabelMouseRel;
    }
}

