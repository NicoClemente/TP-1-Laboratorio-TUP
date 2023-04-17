namespace TP01Punto3
{
    partial class Cantidadarena
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
            this.barea = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.tbaltura = new System.Windows.Forms.TextBox();
            this.tbancho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barea
            // 
            this.barea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barea.Location = new System.Drawing.Point(330, 207);
            this.barea.Name = "barea";
            this.barea.Size = new System.Drawing.Size(153, 84);
            this.barea.TabIndex = 0;
            this.barea.Text = "Calcular cantidad de arena";
            this.barea.UseVisualStyleBackColor = true;
            this.barea.Click += new System.EventHandler(this.barea_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(348, 332);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(119, 39);
            this.bcerrar.TabIndex = 1;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // tbaltura
            // 
            this.tbaltura.Location = new System.Drawing.Point(330, 109);
            this.tbaltura.Name = "tbaltura";
            this.tbaltura.Size = new System.Drawing.Size(153, 20);
            this.tbaltura.TabIndex = 2;
            this.tbaltura.TextChanged += new System.EventHandler(this.tbaltura_TextChanged);
            // 
            // tbancho
            // 
            this.tbancho.Location = new System.Drawing.Point(330, 152);
            this.tbancho.Name = "tbancho";
            this.tbancho.Size = new System.Drawing.Size(153, 20);
            this.tbancho.TabIndex = 3;
            this.tbancho.TextChanged += new System.EventHandler(this.tbancho_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altura pared";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ancho pared";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(730, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "CANTIDAD DE ARENA NECESARIA PARA REVOQUE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cantidadarena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbancho);
            this.Controls.Add(this.tbaltura);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.barea);
            this.Name = "Cantidadarena";
            this.Text = "Cantidad de arena necesaria para revoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button barea;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox tbaltura;
        private System.Windows.Forms.TextBox tbancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

