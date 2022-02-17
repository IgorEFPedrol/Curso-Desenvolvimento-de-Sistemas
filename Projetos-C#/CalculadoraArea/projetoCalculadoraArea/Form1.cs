using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCalculadoraArea
{
    public partial class btnCalc : Form
    {
        public btnCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            try
            {
            double resp = 0;
            double raio = Convert.ToDouble(txtRaio.Text);
            resp = Math.PI * Math.Pow(raio, 2);
            lbResposta.Text = "Área: " + resp.ToString("N2") + "cm quadrados";   
            }
            catch (Exception)
            {
                lbResposta.Text = "Raio Inválido";
                txtRaio.Focus();
            }
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (Char.IsLetter(tecla))
            {
                e.Handled = true;
            }
            if (tecla == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
