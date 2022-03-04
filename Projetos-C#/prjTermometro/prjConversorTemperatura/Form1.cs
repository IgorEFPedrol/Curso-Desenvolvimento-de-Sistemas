using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbFrom_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbFromC.Checked && rbToK.Checked)
            {
                double c = Convert.ToDouble(txtTemperatura.Text);
                double k = c + 273;
                lbTemperatura.Text = k.ToString("N2") + " KELVIN";
            }

            if (rbFromC.Checked && rbToF.Checked)
	        {
                double c = Convert.ToDouble(txtTemperatura.Text);
                double f = c * 1.8 + 32;
                lbTemperatura.Text = f.ToString("N2") + " FAHRENHEIT";
	        }

            if (rbFromC.Checked && rbToC.Checked)
            {
                MessageBox.Show("Conversão Inválida!");
            }

            if (rbFromK.Checked && rbToC.Checked)
            {
                double k = Convert.ToDouble(txtTemperatura.Text);
                double c = k - 273;
                lbTemperatura.Text = c.ToString("N2") + " CELSIUS";
            }

            if (rbFromK.Checked && rbToF.Checked)
	        {
                double k = Convert.ToDouble(txtTemperatura.Text);
                double f = k * 1.8 - 459.67;
                lbTemperatura.Text = f.ToString("N2") + " FAHRENHEIT";
	        }

            if (rbFromK.Checked && rbToK.Checked)
            {
                MessageBox.Show("Conversão Inválida!");
            }

            if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Convert.ToDouble(txtTemperatura.Text);
                double c = (f - 32) / 1.8;
                lbTemperatura.Text = c.ToString("N2") + " CELSIUS";
            }

            if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double k = (f + 459.67) / 1.8;
                lbTemperatura.Text = k.ToString("N2") + " KELVIN";
            }

            if (rbFromF.Checked && rbToF.Checked)
            {
                MessageBox.Show("Conversão Inválida!");
            }
        }


    }
}
