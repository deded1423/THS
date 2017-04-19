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
            this.SuspendLayout();
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.Location = new System.Drawing.Point(12, 12);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfig.TabIndex = 0;
            this.ButtonConfig.Text = "Config";
            this.ButtonConfig.UseVisualStyleBackColor = true;
            this.ButtonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // THS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonConfig);
            this.Name = "THS";
            this.Text = "THS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConfig;
    }
}

