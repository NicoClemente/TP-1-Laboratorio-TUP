namespace TP01Punto5
{
    partial class Fcalculodevuelto
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
            this.tbcliente = new System.Windows.Forms.TextBox();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.tbpago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bvuelto = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.ltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbcliente
            // 
            this.tbcliente.Location = new System.Drawing.Point(379, 112);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(111, 20);
            this.tbcliente.TabIndex = 0;
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(379, 150);
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(111, 20);
            this.tbvalor.TabIndex = 1;
            // 
            // tbpago
            // 
            this.tbpago.Location = new System.Drawing.Point(379, 186);
            this.tbpago.Name = "tbpago";
            this.tbpago.Size = new System.Drawing.Size(111, 20);
            this.tbpago.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del ciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de la compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto pagado";
            // 
            // bvuelto
            // 
            this.bvuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvuelto.Location = new System.Drawing.Point(338, 245);
            this.bvuelto.Name = "bvuelto";
            this.bvuelto.Size = new System.Drawing.Size(152, 58);
            this.bvuelto.TabIndex = 6;
            this.bvuelto.Text = "Calcular Vuelto";
            this.bvuelto.UseVisualStyleBackColor = true;
            this.bvuelto.Click += new System.EventHandler(this.bvuelto_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(338, 328);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(152, 40);
            this.bcerrar.TabIndex = 7;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(212, 46);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(399, 39);
            this.ltitulo.TabIndex = 8;
            this.ltitulo.Text = "CÁLCULO DE VUELTO";
            this.ltitulo.Click += new System.EventHandler(this.ltitulo_Click);
            // 
            // Fcalculodevuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.bvuelto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpago);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.tbcliente);
            this.Name = "Fcalculodevuelto";
            this.Text = "Cálculo de vuelto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcliente;
        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.TextBox tbpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bvuelto;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.Label ltitulo;
    }
}

