namespace TP01Punto4
{
    partial class ConversionMBGB
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
            this.bconversion = new System.Windows.Forms.Button();
            this.tbtamaño = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.lnombre = new System.Windows.Forms.Label();
            this.ltamaño = new System.Windows.Forms.Label();
            this.ltitulo = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            this.lmb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bconversion
            // 
            this.bconversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bconversion.Location = new System.Drawing.Point(343, 196);
            this.bconversion.Name = "bconversion";
            this.bconversion.Size = new System.Drawing.Size(135, 95);
            this.bconversion.TabIndex = 0;
            this.bconversion.Text = "Conversión a GB";
            this.bconversion.UseVisualStyleBackColor = true;
            this.bconversion.Click += new System.EventHandler(this.bconversion_Click);
            // 
            // tbtamaño
            // 
            this.tbtamaño.Location = new System.Drawing.Point(378, 145);
            this.tbtamaño.Name = "tbtamaño";
            this.tbtamaño.Size = new System.Drawing.Size(100, 20);
            this.tbtamaño.TabIndex = 1;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(378, 106);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(158, 20);
            this.tbnombre.TabIndex = 2;
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(163, 100);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(205, 25);
            this.lnombre.TabIndex = 3;
            this.lnombre.Text = "Nombre del archivo:";
            // 
            // ltamaño
            // 
            this.ltamaño.AutoSize = true;
            this.ltamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltamaño.Location = new System.Drawing.Point(270, 140);
            this.ltamaño.Name = "ltamaño";
            this.ltamaño.Size = new System.Drawing.Size(98, 25);
            this.ltamaño.TabIndex = 4;
            this.ltamaño.Text = "Tamaño:";
            this.ltamaño.Click += new System.EventHandler(this.ltamaño_Click);
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(249, 44);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(334, 31);
            this.ltitulo.TabIndex = 5;
            this.ltitulo.Text = "CONVERSION MB A GB";
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(343, 312);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(135, 52);
            this.bcerrar.TabIndex = 6;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // lmb
            // 
            this.lmb.AutoSize = true;
            this.lmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmb.Location = new System.Drawing.Point(484, 145);
            this.lmb.Name = "lmb";
            this.lmb.Size = new System.Drawing.Size(35, 20);
            this.lmb.TabIndex = 7;
            this.lmb.Text = "MB";
            // 
            // ConversionMBGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lmb);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.ltamaño);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbtamaño);
            this.Controls.Add(this.bconversion);
            this.Name = "ConversionMBGB";
            this.Text = "Conversión de MB a GB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bconversion;
        private System.Windows.Forms.TextBox tbtamaño;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label ltamaño;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.Label lmb;
    }
}

