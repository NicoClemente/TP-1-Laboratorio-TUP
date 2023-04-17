namespace TP01Punto7
{
    partial class Sumadigitos
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
            this.ltitulo = new System.Windows.Forms.Label();
            this.txtboxcifra = new System.Windows.Forms.TextBox();
            this.bsumacifras = new System.Windows.Forms.Button();
            this.lcifra = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(18, 49);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(629, 25);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "SUMA DE LOS DÍGITOS DE UN NÚMERO ENTERO POSITIVO";
            this.ltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxcifra
            // 
            this.txtboxcifra.Location = new System.Drawing.Point(247, 133);
            this.txtboxcifra.Name = "txtboxcifra";
            this.txtboxcifra.Size = new System.Drawing.Size(156, 20);
            this.txtboxcifra.TabIndex = 1;
            this.txtboxcifra.TextChanged += new System.EventHandler(this.txtboxcifra_TextChanged);
            // 
            // bsumacifras
            // 
            this.bsumacifras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsumacifras.Location = new System.Drawing.Point(247, 174);
            this.bsumacifras.Name = "bsumacifras";
            this.bsumacifras.Size = new System.Drawing.Size(156, 91);
            this.bsumacifras.TabIndex = 2;
            this.bsumacifras.Text = "Calcular suma de los dígitos";
            this.bsumacifras.UseVisualStyleBackColor = true;
            this.bsumacifras.Click += new System.EventHandler(this.bsumacifras_Click);
            // 
            // lcifra
            // 
            this.lcifra.AutoSize = true;
            this.lcifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcifra.Location = new System.Drawing.Point(176, 94);
            this.lcifra.Name = "lcifra";
            this.lcifra.Size = new System.Drawing.Size(305, 25);
            this.lcifra.TabIndex = 3;
            this.lcifra.Text = "Ingresar número de dos cifras:";
            this.lcifra.Click += new System.EventHandler(this.lcifra_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(261, 283);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(128, 45);
            this.bcerrar.TabIndex = 4;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // Sumadigitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 356);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.lcifra);
            this.Controls.Add(this.bsumacifras);
            this.Controls.Add(this.txtboxcifra);
            this.Controls.Add(this.ltitulo);
            this.Name = "Sumadigitos";
            this.Text = "Suma de los dígitos de un número entero positivo";
            this.Load += new System.EventHandler(this.Sumadigitos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.TextBox txtboxcifra;
        private System.Windows.Forms.Button bsumacifras;
        private System.Windows.Forms.Label lcifra;
        private System.Windows.Forms.Button bcerrar;
    }
}

