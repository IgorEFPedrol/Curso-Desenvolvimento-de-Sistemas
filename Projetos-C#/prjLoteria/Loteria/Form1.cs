using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCartela_Click(object sender, EventArgs e)
        {
            if (rbMegasena.Checked)
            {
                Cartela c = new Cartela(60);
                c.Imprimir(pnCartela, 6, 10);
            }
        }
    }
}
