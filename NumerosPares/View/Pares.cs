using NumerosPares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPares.View
{
    public partial class Pares : Form
    {
        public Pares()
        {
            InitializeComponent();
        }

        private void Pares_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            ParesClass calculo = new ParesClass();
            if (txt_numero.Text != string.Empty)
            {
                int valor = Convert.ToInt32(txt_numero.Text);
                string resultado = calculo.Calcular(valor);
                lbl_resultado.Text = (resultado.ToString());
            }
            else
            {

            }
        }
    }
}
