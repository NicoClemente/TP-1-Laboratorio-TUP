namespace TP01Punto2
{
    partial class Calculoviaje
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
            this.tblugar = new System.Windows.Forms.TextBox();
            this.tbdistancia = new System.Windows.Forms.TextBox();
            this.tbvelocidad = new System.Windows.Forms.TextBox();
            this.llugar = new System.Windows.Forms.Label();
            this.ldistnacia = new System.Windows.Forms.Label();
            this.lvelocidad = new System.Windows.Forms.Label();
            this.ltitulo = new System.Windows.Forms.Label();
            this.lkm = new System.Windows.Forms.Label();
            this.lkmh = new System.Windows.Forms.Label();
            this.btiempo = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblugar
            // 
            this.tblugar.Location = new System.Drawing.Point(330, 131);
            this.tblugar.Name = "tblugar";
            this.tblugar.Size = new System.Drawing.Size(153, 20);
            this.tblugar.TabIndex = 0;
            this.tblugar.TextChanged += new System.EventHandler(this.tblugar_TextChanged);
            // 
            // tbdistancia
            // 
            this.tbdistancia.Location = new System.Drawing.Point(330, 179);
            this.tbdistancia.Name = "tbdistancia";
            this.tbdistancia.Size = new System.Drawing.Size(153, 20);
            this.tbdistancia.TabIndex = 1;
            this.tbdistancia.TextChanged += new System.EventHandler(this.tbdistancia_TextChanged);
            // 
            // tbvelocidad
            // 
            this.tbvelocidad.Location = new System.Drawing.Point(329, 227);
            this.tbvelocidad.Name = "tbvelocidad";
            this.tbvelocidad.Size = new System.Drawing.Size(153, 20);
            this.tbvelocidad.TabIndex = 2;
            // 
            // llugar
            // 
            this.llugar.AutoSize = true;
            this.llugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llugar.Location = new System.Drawing.Point(231, 125);
            this.llugar.Name = "llugar";
            this.llugar.Size = new System.Drawing.Size(92, 25);
            this.llugar.TabIndex = 3;
            this.llugar.Text = "Destino:";
            this.llugar.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldistnacia
            // 
            this.ldistnacia.AutoSize = true;
            this.ldistnacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldistnacia.Location = new System.Drawing.Point(215, 174);
            this.ldistnacia.Name = "ldistnacia";
            this.ldistnacia.Size = new System.Drawing.Size(108, 25);
            this.ldistnacia.TabIndex = 4;
            this.ldistnacia.Text = "Distancia:";
            this.ldistnacia.Click += new System.EventHandler(this.ldistnacia_Click);
            // 
            // lvelocidad
            // 
            this.lvelocidad.AutoSize = true;
            this.lvelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvelocidad.Location = new System.Drawing.Point(208, 222);
            this.lvelocidad.Name = "lvelocidad";
            this.lvelocidad.Size = new System.Drawing.Size(115, 25);
            this.lvelocidad.TabIndex = 5;
            this.lvelocidad.Text = "Velocidad:";
            this.lvelocidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(127, 49);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(568, 39);
            this.ltitulo.TabIndex = 6;
            this.ltitulo.Text = "TIEMPO QUE DURARÁ EL VIAJE";
            this.ltitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lkm
            // 
            this.lkm.AutoSize = true;
            this.lkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkm.Location = new System.Drawing.Point(489, 179);
            this.lkm.Name = "lkm";
            this.lkm.Size = new System.Drawing.Size(30, 17);
            this.lkm.TabIndex = 7;
            this.lkm.Text = "Km";
            // 
            // lkmh
            // 
            this.lkmh.AutoSize = true;
            this.lkmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkmh.Location = new System.Drawing.Point(488, 228);
            this.lkmh.Name = "lkmh";
            this.lkmh.Size = new System.Drawing.Size(44, 17);
            this.lkmh.TabIndex = 8;
            this.lkmh.Text = "Km/h";
            // 
            // btiempo
            // 
            this.btiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiempo.Location = new System.Drawing.Point(341, 276);
            this.btiempo.Name = "btiempo";
            this.btiempo.Size = new System.Drawing.Size(131, 72);
            this.btiempo.TabIndex = 9;
            this.btiempo.Text = "Calcular tiempo";
            this.btiempo.UseVisualStyleBackColor = true;
            this.btiempo.Click += new System.EventHandler(this.btiempo_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(340, 369);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(132, 49);
            this.bcerrar.TabIndex = 10;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // Calculoviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 469);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.btiempo);
            this.Controls.Add(this.lkmh);
            this.Controls.Add(this.lkm);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.lvelocidad);
            this.Controls.Add(this.ldistnacia);
            this.Controls.Add(this.llugar);
            this.Controls.Add(this.tbvelocidad);
            this.Controls.Add(this.tbdistancia);
            this.Controls.Add(this.tblugar);
            this.Name = "Calculoviaje";
            this.Text = "Cálculo de tiempo de viaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblugar;
        private System.Windows.Forms.TextBox tbdistancia;
        private System.Windows.Forms.TextBox tbvelocidad;
        private System.Windows.Forms.Label llugar;
        private System.Windows.Forms.Label ldistnacia;
        private System.Windows.Forms.Label lvelocidad;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Label lkm;
        private System.Windows.Forms.Label lkmh;
        private System.Windows.Forms.Button btiempo;
        private System.Windows.Forms.Button bcerrar;
    }
}

