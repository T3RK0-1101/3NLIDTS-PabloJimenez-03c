using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_PabloJimenez_03c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se borraron los datos", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            /*tbkelvin.Text="0";
            tbfarenheit.Text = "0";
            tbcelcius.Text = "0";*/
            tbcelcius.Clear();
            tbfarenheit.Clear();
            tbkelvin.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            /*!string.IsNullOrEmpty(tbcelcius.Text) || !string.IsNullOrEmpty(tbfarenheit.Text) || !string.IsNullOrEmpty(tbkelvin.Text*/
            /*string.IsNullOrEmpty(tbcelcius.Text) && !string.IsNullOrEmpty(tbfarenheit.Text) && !string.IsNullOrEmpty(tbkelvin.Text*/
            //tbcelcius.Text != "" || tbkelvin.Text != "" || tbfarenheit.Text != ""
            if (!string.IsNullOrEmpty(tbcelcius.Text))
            {
                MessageBox.Show("CALCULANDO", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //calculo celcius a farentheit
                float Cl = float.Parse(tbcelcius.Text);
                float calFA = (Cl * 9 / 5) + 32;
                tbfarenheit.Text = calFA.ToString();

                //Celccius a kelvin
                float Kl = Cl + 273;
                tbkelvin.Text = Kl.ToString();

            }
            else if (!string.IsNullOrEmpty(tbfarenheit.Text))
            {
                MessageBox.Show("CALCULANDO", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //farenheit a celcius
                float Fa = float.Parse(tbfarenheit.Text);
                float calCl = (Fa - 32f) * 5 / 9;
                tbcelcius.Text = calCl.ToString();

                //farenheit a kelvin 
                float Kl = ((Fa - 32)*5)/9 + 273;
                tbkelvin.Text = Kl.ToString();
            }
            else if (!string.IsNullOrEmpty(tbkelvin.Text))
            {
                MessageBox.Show("CALCULANDO", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //kelvin a celcius
                float kv = float.Parse(tbkelvin.Text);
                float cel = kv - 273;
                tbcelcius.Text = cel.ToString();

                //Kelvin a fereanheit
                float fa = ((kv - 273) * 9) / 5 + 32;
                tbfarenheit.Text = fa.ToString();
            }
            else { MessageBox.Show("Ingrese los valores para calcular", "Aguas we", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
