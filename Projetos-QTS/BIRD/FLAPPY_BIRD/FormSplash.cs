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
    }
}
