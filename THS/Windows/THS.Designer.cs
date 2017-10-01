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
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.buttonTest4 = new System.Windows.Forms.Button();
            this.buttonTest5 = new System.Windows.Forms.Button();
            this.buttonTest6 = new System.Windows.Forms.Button();
            this.buttonTest7 = new System.Windows.Forms.Button();
            this.buttonTest8 = new System.Windows.Forms.Button();
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
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(200, 35);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(92, 36);
            this.buttonTest1.TabIndex = 18;
            this.buttonTest1.Text = "Test 1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(298, 35);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(92, 36);
            this.buttonTest2.TabIndex = 19;
            this.buttonTest2.Text = "Test 2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest3
            // 
            this.buttonTest3.Location = new System.Drawing.Point(200, 77);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(92, 36);
            this.buttonTest3.TabIndex = 20;
            this.buttonTest3.Text = "Test 3";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest4
            // 
            this.buttonTest4.Location = new System.Drawing.Point(298, 77);
            this.buttonTest4.Name = "buttonTest4";
            this.buttonTest4.Size = new System.Drawing.Size(92, 36);
            this.buttonTest4.TabIndex = 21;
            this.buttonTest4.Text = "Test 4";
            this.buttonTest4.UseVisualStyleBackColor = true;
            this.buttonTest4.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest5
            // 
            this.buttonTest5.Location = new System.Drawing.Point(200, 119);
            this.buttonTest5.Name = "buttonTest5";
            this.buttonTest5.Size = new System.Drawing.Size(92, 36);
            this.buttonTest5.TabIndex = 22;
            this.buttonTest5.Text = "Test 5";
            this.buttonTest5.UseVisualStyleBackColor = true;
            this.buttonTest5.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest6
            // 
            this.buttonTest6.Location = new System.Drawing.Point(298, 119);
            this.buttonTest6.Name = "buttonTest6";
            this.buttonTest6.Size = new System.Drawing.Size(92, 36);
            this.buttonTest6.TabIndex = 23;
            this.buttonTest6.Text = "Test 6";
            this.buttonTest6.UseVisualStyleBackColor = true;
            this.buttonTest6.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest7
            // 
            this.buttonTest7.Location = new System.Drawing.Point(200, 161);
            this.buttonTest7.Name = "buttonTest7";
            this.buttonTest7.Size = new System.Drawing.Size(92, 36);
            this.buttonTest7.TabIndex = 24;
            this.buttonTest7.Text = "Test 7";
            this.buttonTest7.UseVisualStyleBackColor = true;
            this.buttonTest7.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTest8
            // 
            this.buttonTest8.Location = new System.Drawing.Point(298, 161);
            this.buttonTest8.Name = "buttonTest8";
            this.buttonTest8.Size = new System.Drawing.Size(92, 36);
            this.buttonTest8.TabIndex = 25;
            this.buttonTest8.Text = "Test 8";
            this.buttonTest8.UseVisualStyleBackColor = true;
            this.buttonTest8.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // THS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.Controls.Add(this.buttonTest8);
            this.Controls.Add(this.buttonTest7);
            this.Controls.Add(this.buttonTest6);
            this.Controls.Add(this.buttonTest5);
            this.Controls.Add(this.buttonTest4);
            this.Controls.Add(this.buttonTest3);
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.buttonTest1);
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
        private CheckBox checkBoxTCP;
        protected Button buttonStartTCP;
        private CheckBox checkBoxHs;
        protected Button buttonTest1;
        protected Button buttonTest2;
        protected Button buttonTest3;
        protected Button buttonTest4;
        protected Button buttonTest5;
        protected Button buttonTest6;
        protected Button buttonTest7;
        protected Button buttonTest8;
    }
}

