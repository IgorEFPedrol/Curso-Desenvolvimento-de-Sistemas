using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPY_BIRD
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        string Serial = "YTt2crwtYoo7";

        private void btnRegistrarProduto_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Equals(Serial))
            {
                Registro.Gravar("FLAPPY", "serial", Cripto.Codificar(Serial));
                this.Dispose();
            }
            else
            {
                MessageBox.Show("SERIAL INVÁLIDO", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
