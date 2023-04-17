using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto2
{
    public partial class Calculoviaje : Form
    {
        public Calculoviaje()
        {
            InitializeComponent();
        }

        private void btiempo_Click(object sender, EventArgs e)
        {
            string Destino = tblugar.Text;
            //Calcular Tiempo
            double Distancia = Convert.ToDouble(tbdistancia.Text);
            double Velocidad = Convert.ToDouble(tbvelocidad.Text);
            double Tiempo = Distancia / Velocidad;
            string valorreducido = Tiempo.ToString("0.0");


            //Muestra el resultado
            MessageBox.Show($"El tiempo para llegar a {Destino} es: " + valorreducido + " horas "); //Espacio entre comillas en horas para que no quede pegado al tiempo
                                                                                                    //Tambien puede usarse {} en vez de + y " (salvo primero y ultimo)
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón cerrar
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ldistnacia_Click(object sender, EventArgs e)
        {

        }

        private void tblugar_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void tbdistancia_TextChanged(object sender, EventArgs e)
        {

        }
               
    }
}
