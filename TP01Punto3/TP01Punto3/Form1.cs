using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto3
{
    public partial class Cantidadarena : Form
    {
        public Cantidadarena()
        {
            InitializeComponent();
        }
        private void barea_Click(object sender, EventArgs e)
        {
            //Cálculo de arena necesaria
            double altura = Convert.ToDouble(tbaltura.Text);
            double ancho = Convert.ToDouble(tbancho.Text);
            double area = ancho * altura * 0.5;
            string valorreducido = area.ToString(" 0.0 ");

            //mostrar resultado
            MessageBox.Show("Cantidad de arena necesaria: " + valorreducido + " m3 ");
        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón de cerrar
            Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbaltura_TextChanged(object sender, EventArgs e)
        {

        }
               
        private void tbancho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
