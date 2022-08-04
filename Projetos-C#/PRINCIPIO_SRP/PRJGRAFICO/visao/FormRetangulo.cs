using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJGRAFICO.visao
{
    public partial class FormRetangulo : Form
    {
        public FormRetangulo()
        {
            InitializeComponent();
        }

        private void btnPlotar_Click(object sender, EventArgs e)
        {
            modelo.RetMatematico ret = new modelo.RetMatematico(
                Double.Parse(txtA.Text),
                Double.Parse(txtC.Text));
            controle.RetGrafico graf = new controle.RetGrafico(
                pnDesenho.CreateGraphics());
            graf.Desenhar(ret);
        }
    }
}
