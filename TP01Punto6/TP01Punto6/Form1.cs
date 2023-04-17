using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto6
{
    public partial class Porcentajeocupacion : Form
    {
        public Porcentajeocupacion()
        {
            InitializeComponent();
        }

        private void porcentajeocupacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bporcentaje_Click(object sender, EventArgs e)
        {
            //Cálculo de porcentaje de ocupación
            int cupo = Convert.ToInt32(tbcupo.Text);
            int persona = Convert.ToInt32(tbpersonas.Text); //.Text devuelve un string
            int porcentaje = (persona * 100) / cupo;

            //Mensaje de porcentaje de ocupación
            MessageBox.Show($"El porcentaje de ocupación es de: {porcentaje} %");


        }

        private void bmenos_Click(object sender, EventArgs e)
           //Codigo para restar personas
        {
            if (tbpersonas.Text != "") // desigualdad (!=) devuelve true si sus operandos no son iguales; en caso contrario, devuelve false
            {
                int aux = Convert.ToInt32(tbpersonas.Text) - 1;
                if (aux > 0)
                {
                    tbpersonas.Text = aux.ToString();
                }
            }
        }
        private void bmas_Click(object sender, EventArgs e)
           //Codigo para sumar personas
        {
            if (tbpersonas.Text != "")
            {
                int aux = Convert.ToInt32(tbpersonas.Text) + 1;
                if (aux < Convert.ToInt32(tbcupo.Text))
                {
                    tbpersonas.Text = aux.ToString();
                }
            }
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón de cerrar
            Close();
        }
    }
}