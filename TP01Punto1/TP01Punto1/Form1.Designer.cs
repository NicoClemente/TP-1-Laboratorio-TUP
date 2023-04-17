namespace TP01Punto1
{
    partial class CalculoAreaPerimetro
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.barea = new System.Windows.Forms.Button();
            this.bperimetro = new System.Windows.Forms.Button();
            this.tbradio = new System.Windows.Forms.TextBox();
            this.lradio = new System.Windows.Forms.Label();
            this.ltitulo = new System.Windows.Forms.Label();
            this.tbunidad = new System.Windows.Forms.TextBox();
            this.lunidad = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // barea
            // 
            this.barea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barea.Location = new System.Drawing.Point(174, 144);
            this.barea.Name = "barea";
            this.barea.Size = new System.Drawing.Size(117, 52);
            this.barea.TabIndex = 0;
            this.barea.Text = "Calcular Área";
            this.barea.UseVisualStyleBackColor = true;
            this.barea.Click += new System.EventHandler(this.barea_Click);
            // 
            // bperimetro
            // 
            this.bperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bperimetro.Location = new System.Drawing.Point(174, 202);
            this.bperimetro.Name = "bperimetro";
            this.bperimetro.Size = new System.Drawing.Size(117, 49);
            this.bperimetro.TabIndex = 1;
            this.bperimetro.Text = "Calcular Perímetro";
            this.bperimetro.UseVisualStyleBackColor = true;
            this.bperimetro.Click += new System.EventHandler(this.bperimetro_Click);
            // 
            // tbradio
            // 
            this.tbradio.Location = new System.Drawing.Point(297, 90);
            this.tbradio.Name = "tbradio";
            this.tbradio.Size = new System.Drawing.Size(121, 20);
            this.tbradio.TabIndex = 2;
            this.tbradio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lradio
            // 
            this.lradio.AutoSize = true;
            this.lradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lradio.Location = new System.Drawing.Point(171, 91);
            this.lradio.Name = "lradio";
            this.lradio.Size = new System.Drawing.Size(120, 17);
            this.lradio.TabIndex = 4;
            this.lradio.Text = "Valor del Radio";
            this.lradio.Click += new System.EventHandler(this.label1_Click);
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(169, 40);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(493, 29);
            this.ltitulo.TabIndex = 5;
            this.ltitulo.Text = "Calculo de área y perímetro de un círculo";
            this.ltitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbunidad
            // 
            this.tbunidad.Location = new System.Drawing.Point(424, 90);
            this.tbunidad.Name = "tbunidad";
            this.tbunidad.Size = new System.Drawing.Size(36, 20);
            this.tbunidad.TabIndex = 3;
            this.tbunidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lunidad
            // 
            this.lunidad.AutoSize = true;
            this.lunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunidad.Location = new System.Drawing.Point(466, 91);
            this.lunidad.Name = "lunidad";
            this.lunidad.Size = new System.Drawing.Size(215, 17);
            this.lunidad.TabIndex = 6;
            this.lunidad.Text = "← Indique unidad de medida";
            this.lunidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(174, 297);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(83, 33);
            this.bcerrar.TabIndex = 7;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click_1);
            // 
            // CalculoAreaPerimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.lunidad);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.lradio);
            this.Controls.Add(this.tbunidad);
            this.Controls.Add(this.tbradio);
            this.Controls.Add(this.bperimetro);
            this.Controls.Add(this.barea);
            this.Name = "CalculoAreaPerimetro";
            this.Text = "Cálculo área y perímetro";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button bperimetro;
        private System.Windows.Forms.Button barea;
        private System.Windows.Forms.TextBox tbradio;
        private System.Windows.Forms.Label lradio;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Label lunidad;
        private System.Windows.Forms.TextBox tbunidad;
        private System.Windows.Forms.Button bcerrar;
    }
}

