using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto1
{
    public partial class CalculoAreaPerimetro : Form
    {
        public CalculoAreaPerimetro()
        {
            InitializeComponent();
        }
        double Perimetro;
        double Radio;
        double Area;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void barea_Click(object sender, EventArgs e)
        {
            string unidadMedida = tbunidad.Text;
            
            //Calcular Área
            Radio = Convert.ToDouble(tbradio.Text);
            Area = Math.PI * Math.Pow(Radio, 2);
            string valorreducido1 = Area.ToString("0.00");

            //Muestra el resultado
            MessageBox.Show("El area del circulo es: " + valorreducido1 + " " + unidadMedida);
        }

        private void bperimetro_Click(object sender, EventArgs e)
        {
            string unidadMedida = tbunidad.Text;
            
            //Calcular perímetro
            Radio = Convert.ToDouble(tbradio.Text);
            Perimetro = 2 * Math.PI * Radio;
            string valorreducido = Perimetro.ToString("0.00");
            

            //Muestra el resultado
            MessageBox.Show("El perimetro del circulo es: " + valorreducido + " " + unidadMedida);
        }
        private void bcerrar_Click_1(object sender, EventArgs e)
        {
            //Boton cerrar
            Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
