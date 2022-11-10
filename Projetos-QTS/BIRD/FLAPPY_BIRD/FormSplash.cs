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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            barra.Increment(1);

            lbPorcento.Text = barra.Value.ToString().PadLeft(3, '0') +
                " %";
            lbUsuario.Text = "USUÁRIO: " +
                Environment.UserName + "(" +
                Environment.MachineName + ")";
            

            if (barra.Value == 100)
            {
                this.Cursor = Cursors.Default;
                timerSplash.Stop();
            }
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
