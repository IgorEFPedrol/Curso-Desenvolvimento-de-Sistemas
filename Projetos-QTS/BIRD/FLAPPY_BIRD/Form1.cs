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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravidade = 15;
        int speed = 25  ;
        int placar = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = -20;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = 15;
            }
        }

        private void jogo_Tick(object sender, EventArgs e)
        {
            bird.Top += gravidade;
            tuboInferior.Left -= speed;
            tuboSuperior.Left -= speed;
            if (tuboInferior.Left < 0 - tuboInferior.Width * 2)
            {
                tuboInferior.Left = this.Width + tuboInferior.Width * 2;
                placar++;
            }
            if (tuboSuperior.Left < 0 - tuboSuperior.Width * 2)
            {
                tuboSuperior.Left = this.Width + tuboSuperior.Width * 2;
                placar++;
            }
            if (bird.Bounds.IntersectsWith(tuboInferior.Bounds) || bird.Bounds.IntersectsWith(tuboSuperior.Bounds))
            {
                jogo.Stop();
                lbMensagem.Text = "Você Perdeu!";
            }
            lbPlacar.Text = String.Format("PLACAR: {0}", placar.ToString().PadLeft(4, '0'));
        }

        
    }
}
