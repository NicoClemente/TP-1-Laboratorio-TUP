namespace TP01Punto9
{
    partial class Sumahorarios
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
            this.txtboxhoras1 = new System.Windows.Forms.TextBox();
            this.bsumahorarios = new System.Windows.Forms.Button();
            this.txtboxhoras2 = new System.Windows.Forms.TextBox();
            this.txtboxminutos1 = new System.Windows.Forms.TextBox();
            this.txtboxminutos2 = new System.Windows.Forms.TextBox();
            this.txtboxsegundos1 = new System.Windows.Forms.TextBox();
            this.txtboxsegundos2 = new System.Windows.Forms.TextBox();
            this.ltitulo = new System.Windows.Forms.Label();
            this.lhorario1 = new System.Windows.Forms.Label();
            this.lhorario2 = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            this.lhs1 = new System.Windows.Forms.Label();
            this.lhs2 = new System.Windows.Forms.Label();
            this.lmin1 = new System.Windows.Forms.Label();
            this.lmin2 = new System.Windows.Forms.Label();
            this.lseg1 = new System.Windows.Forms.Label();
            this.lseg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxhoras1
            // 
            this.txtboxhoras1.Location = new System.Drawing.Point(144, 127);
            this.txtboxhoras1.Name = "txtboxhoras1";
            this.txtboxhoras1.Size = new System.Drawing.Size(100, 20);
            this.txtboxhoras1.TabIndex = 0;
            // 
            // bsumahorarios
            // 
            this.bsumahorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsumahorarios.Location = new System.Drawing.Point(235, 199);
            this.bsumahorarios.Name = "bsumahorarios";
            this.bsumahorarios.Size = new System.Drawing.Size(150, 70);
            this.bsumahorarios.TabIndex = 1;
            this.bsumahorarios.Text = "Suma de horarios";
            this.bsumahorarios.UseVisualStyleBackColor = true;
            this.bsumahorarios.Click += new System.EventHandler(this.bsumahorarios_Click);
            // 
            // txtboxhoras2
            // 
            this.txtboxhoras2.Location = new System.Drawing.Point(144, 153);
            this.txtboxhoras2.Name = "txtboxhoras2";
            this.txtboxhoras2.Size = new System.Drawing.Size(100, 20);
            this.txtboxhoras2.TabIndex = 2;
            // 
            // txtboxminutos1
            // 
            this.txtboxminutos1.Location = new System.Drawing.Point(295, 125);
            this.txtboxminutos1.Name = "txtboxminutos1";
            this.txtboxminutos1.Size = new System.Drawing.Size(100, 20);
            this.txtboxminutos1.TabIndex = 3;
            // 
            // txtboxminutos2
            // 
            this.txtboxminutos2.Location = new System.Drawing.Point(295, 151);
            this.txtboxminutos2.Name = "txtboxminutos2";
            this.txtboxminutos2.Size = new System.Drawing.Size(100, 20);
            this.txtboxminutos2.TabIndex = 4;
            // 
            // txtboxsegundos1
            // 
            this.txtboxsegundos1.Location = new System.Drawing.Point(451, 125);
            this.txtboxsegundos1.Name = "txtboxsegundos1";
            this.txtboxsegundos1.Size = new System.Drawing.Size(100, 20);
            this.txtboxsegundos1.TabIndex = 5;
            // 
            // txtboxsegundos2
            // 
            this.txtboxsegundos2.Location = new System.Drawing.Point(451, 151);
            this.txtboxsegundos2.Name = "txtboxsegundos2";
            this.txtboxsegundos2.Size = new System.Drawing.Size(100, 20);
            this.txtboxsegundos2.TabIndex = 6;
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(187, 50);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(247, 31);
            this.ltitulo.TabIndex = 7;
            this.ltitulo.Text = "Suma de Horarios";
            this.ltitulo.Click += new System.EventHandler(this.ltitulo_Click);
            // 
            // lhorario1
            // 
            this.lhorario1.AutoSize = true;
            this.lhorario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhorario1.Location = new System.Drawing.Point(49, 125);
            this.lhorario1.Name = "lhorario1";
            this.lhorario1.Size = new System.Drawing.Size(89, 22);
            this.lhorario1.TabIndex = 8;
            this.lhorario1.Text = "Horario 1:";
            // 
            // lhorario2
            // 
            this.lhorario2.AutoSize = true;
            this.lhorario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhorario2.Location = new System.Drawing.Point(49, 151);
            this.lhorario2.Name = "lhorario2";
            this.lhorario2.Size = new System.Drawing.Size(89, 22);
            this.lhorario2.TabIndex = 9;
            this.lhorario2.Text = "Horario 2:";
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(257, 290);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(106, 44);
            this.bcerrar.TabIndex = 10;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // lhs1
            // 
            this.lhs1.AutoSize = true;
            this.lhs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhs1.Location = new System.Drawing.Point(244, 130);
            this.lhs1.Name = "lhs1";
            this.lhs1.Size = new System.Drawing.Size(27, 17);
            this.lhs1.TabIndex = 11;
            this.lhs1.Text = "Hs";
            // 
            // lhs2
            // 
            this.lhs2.AutoSize = true;
            this.lhs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhs2.Location = new System.Drawing.Point(244, 156);
            this.lhs2.Name = "lhs2";
            this.lhs2.Size = new System.Drawing.Size(27, 17);
            this.lhs2.TabIndex = 12;
            this.lhs2.Text = "Hs";
            // 
            // lmin1
            // 
            this.lmin1.AutoSize = true;
            this.lmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmin1.Location = new System.Drawing.Point(396, 128);
            this.lmin1.Name = "lmin1";
            this.lmin1.Size = new System.Drawing.Size(33, 17);
            this.lmin1.TabIndex = 13;
            this.lmin1.Text = "Min";
            // 
            // lmin2
            // 
            this.lmin2.AutoSize = true;
            this.lmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmin2.Location = new System.Drawing.Point(396, 156);
            this.lmin2.Name = "lmin2";
            this.lmin2.Size = new System.Drawing.Size(33, 17);
            this.lmin2.TabIndex = 14;
            this.lmin2.Text = "Min";
            this.lmin2.Click += new System.EventHandler(this.lmin2_Click);
            // 
            // lseg1
            // 
            this.lseg1.AutoSize = true;
            this.lseg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lseg1.Location = new System.Drawing.Point(557, 128);
            this.lseg1.Name = "lseg1";
            this.lseg1.Size = new System.Drawing.Size(36, 17);
            this.lseg1.TabIndex = 15;
            this.lseg1.Text = "Seg";
            // 
            // lseg2
            // 
            this.lseg2.AutoSize = true;
            this.lseg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lseg2.Location = new System.Drawing.Point(557, 154);
            this.lseg2.Name = "lseg2";
            this.lseg2.Size = new System.Drawing.Size(36, 17);
            this.lseg2.TabIndex = 16;
            this.lseg2.Text = "Seg";
            // 
            // Sumahorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 410);
            this.Controls.Add(this.lseg2);
            this.Controls.Add(this.lseg1);
            this.Controls.Add(this.lmin2);
            this.Controls.Add(this.lmin1);
            this.Controls.Add(this.lhs2);
            this.Controls.Add(this.lhs1);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.lhorario2);
            this.Controls.Add(this.lhorario1);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.txtboxsegundos2);
            this.Controls.Add(this.txtboxsegundos1);
            this.Controls.Add(this.txtboxminutos2);
            this.Controls.Add(this.txtboxminutos1);
            this.Controls.Add(this.txtboxhoras2);
            this.Controls.Add(this.bsumahorarios);
            this.Controls.Add(this.txtboxhoras1);
            this.Name = "Sumahorarios";
            this.Text = "Suma de horarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxhoras1;
        private System.Windows.Forms.Button bsumahorarios;
        private System.Windows.Forms.TextBox txtboxhoras2;
        private System.Windows.Forms.TextBox txtboxminutos1;
        private System.Windows.Forms.TextBox txtboxminutos2;
        private System.Windows.Forms.TextBox txtboxsegundos1;
        private System.Windows.Forms.TextBox txtboxsegundos2;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Label lhorario1;
        private System.Windows.Forms.Label lhorario2;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.Label lhs1;
        private System.Windows.Forms.Label lhs2;
        private System.Windows.Forms.Label lmin1;
        private System.Windows.Forms.Label lmin2;
        private System.Windows.Forms.Label lseg1;
        private System.Windows.Forms.Label lseg2;
    }
}

