namespace MetroCaliSimulator
{
    partial class Form1
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
            this.butVerMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butVerMapa
            // 
            this.butVerMapa.Location = new System.Drawing.Point(130, 97);
            this.butVerMapa.Name = "butVerMapa";
            this.butVerMapa.Size = new System.Drawing.Size(113, 66);
            this.butVerMapa.TabIndex = 0;
            this.butVerMapa.Text = "Ver Simulación";
            this.butVerMapa.UseVisualStyleBackColor = true;
            this.butVerMapa.Click += new System.EventHandler(this.ButVerMapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 286);
            this.Controls.Add(this.butVerMapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butVerMapa;
    }
}

