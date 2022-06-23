using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestaurante.visao
{
    public partial class FormPrincipal : Form
    {
        public FormProduto frProdutos = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja sair",
                "Mensagem", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            if (frProdutos == null)
            {
                frProdutos = new FormProduto();
                frProdutos.MdiParent = this;
                frProdutos.StartPosition = FormStartPosition.Manual;
                frProdutos.Location = new Point(0, 0);
                frProdutos.Show();
            }
        }


    }
}
