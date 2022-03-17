using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbArea.Checked == true)
            {
                double r = Convert.ToDouble(txtRaio.Text);
                double a = Math.PI * Math.Pow(r, 2);
                lbResultado.Text = "ÁREA = " + a.ToString("N3");
            }

            if (rbPerimetro.Checked == true)
            {
                double r = Convert.ToDouble(txtRaio.Text);
                double p = 2 * Math.PI * r;
                lbResultado.Text = "PERÍMETRO = " + p.ToString("N3");
            }

            if (rbVolume.Checked == true)
            {
                double r = Convert.ToDouble(txtRaio.Text);
                double v = 3f / 4f * Math.PI * Math.Pow(r, 3);
                lbResultado.Text = "VOLUME = " + v.ToString("N3");
            }

            if (opDesenhar.Checked == true)
                DesenharCirculo();
            
            else pnDesenho.CreateGraphics().Clear(pnDesenho.BackColor);
            
        }

        private void DesenharCirculo()
        {
            Graphics tela = pnDesenho.CreateGraphics();
            double diametro = Convert.ToDouble(txtRaio.Text) * 2;
            Pen caneta = new Pen(Color.Blue, 3);
            tela.Clear(pnDesenho.BackColor);
            int x = pnDesenho.Width / 2;
            int y = pnDesenho.Height / 2;
            tela.DrawEllipse(caneta, (int)(x-diametro / 2))
        }
    }
}
