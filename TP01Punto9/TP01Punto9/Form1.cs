using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto9
{
    public partial class Sumahorarios : Form
    {
        public Sumahorarios()
        {
            InitializeComponent();
        }

        private void bsumahorarios_Click(object sender, EventArgs e)
        {
            int Horas1 = Convert.ToInt32(txtboxhoras1.Text);
            int Horas2 = Convert.ToInt32(txtboxhoras2.Text);
            int Minutos1 = Convert.ToInt32(txtboxminutos1.Text);
            int Minutos2 = Convert.ToInt32(txtboxminutos2.Text);
            int Segundos1 = Convert.ToInt32(txtboxsegundos1.Text);
            int Segundos2 = Convert.ToInt32(txtboxsegundos2.Text);
            int Sumahoras = Horas1 + Horas2;
            int Sumaminutos = Minutos1 + Minutos2;
            int Sumasegundos = Segundos1 + Segundos2;

            MessageBox.Show($"La suma de horarios es de: {Sumahoras} hs, {Sumaminutos} min y {Sumasegundos} seg");

        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lmin2_Click(object sender, EventArgs e)
        {

        }
    }
}
