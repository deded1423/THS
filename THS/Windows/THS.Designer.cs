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
            this.CheckBoxTCP = new System.Windows.Forms.CheckBox();
            this.ButtonTest1 = new System.Windows.Forms.Button();
            this.LabelRead = new System.Windows.Forms.Label();
            this.LabelReadText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTCP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // CheckBoxTCP
            // 
            this.CheckBoxTCP.AutoSize = true;
            this.CheckBoxTCP.Location = new System.Drawing.Point(8, 12);
            this.CheckBoxTCP.Name = "CheckBoxTCP";
            this.CheckBoxTCP.Size = new System.Drawing.Size(133, 17);
            this.CheckBoxTCP.TabIndex = 2;
            this.CheckBoxTCP.Text = "Recieve Through TCP";
            this.CheckBoxTCP.UseVisualStyleBackColor = true;
            // 
            // ButtonTest1
            // 
            this.ButtonTest1.Location = new System.Drawing.Point(34, 35);
            this.ButtonTest1.Name = "ButtonTest1";
            this.ButtonTest1.Size = new System.Drawing.Size(47, 23);
            this.ButtonTest1.TabIndex = 3;
            this.ButtonTest1.Text = "TEST";
            this.ButtonTest1.UseVisualStyleBackColor = true;
            this.ButtonTest1.Click += new System.EventHandler(this.ButtonTest1_Click);
            // 
            // LabelRead
            // 
            this.LabelRead.AutoSize = true;
            this.LabelRead.Location = new System.Drawing.Point(296, 112);
            this.LabelRead.Name = "LabelRead";
            this.LabelRead.Size = new System.Drawing.Size(13, 13);
            this.LabelRead.TabIndex = 4;
            this.LabelRead.Text = "0";
            // 
            // LabelReadText
            // 
            this.LabelReadText.AutoSize = true;
            this.LabelReadText.Location = new System.Drawing.Point(255, 112);
            this.LabelReadText.Name = "LabelReadText";
            this.LabelReadText.Size = new System.Drawing.Size(36, 13);
            this.LabelReadText.TabIndex = 5;
            this.LabelReadText.Text = "Read:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TCP";
            // 
            // LabelTCP
            // 
            this.LabelTCP.AutoSize = true;
            this.LabelTCP.Location = new System.Drawing.Point(296, 99);
            this.LabelTCP.Name = "LabelTCP";
            this.LabelTCP.Size = new System.Drawing.Size(13, 13);
            this.LabelTCP.TabIndex = 6;
            this.LabelTCP.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label1";
            // 
            // THS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTCP);
            this.Controls.Add(this.LabelReadText);
            this.Controls.Add(this.LabelRead);
            this.Controls.Add(this.ButtonTest1);
            this.Controls.Add(this.CheckBoxTCP);
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
        protected System.Windows.Forms.CheckBox CheckBoxTCP;
        protected System.Windows.Forms.Button ButtonTest1;
        public System.Windows.Forms.Label LabelRead;
        private System.Windows.Forms.Label LabelReadText;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LabelTCP;
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

        private Label label3;
        public Label label4;
    }
}

