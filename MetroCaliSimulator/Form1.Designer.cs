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
            this.butVerMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butVerMapa.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVerMapa.ForeColor = System.Drawing.Color.White;
            this.butVerMapa.Location = new System.Drawing.Point(174, 173);
            this.butVerMapa.Name = "butVerMapa";
            this.butVerMapa.Size = new System.Drawing.Size(211, 31);
            this.butVerMapa.TabIndex = 0;
            this.butVerMapa.Text = "VER SIMULACIÓN";
            this.butVerMapa.UseVisualStyleBackColor = false;
            this.butVerMapa.Click += new System.EventHandler(this.ButVerMapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MetroCaliSimulator.Properties.Resources.MioPrincipal;
            this.ClientSize = new System.Drawing.Size(529, 449);
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

