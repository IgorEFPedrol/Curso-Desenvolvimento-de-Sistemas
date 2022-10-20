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

        int gravidade = 5;
        int speed = 8;
        int placar = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = 5;
            }
        }

        private void jogo_Tick(object sender, EventArgs e)
        {
            bird.Top += gravidade;
            tuboInferior.Left -= speed;
            tuboSuperior.Left -= speed;
            if (tuboInferior.Left < 0 - tuboInferior.Width * 2)
            {
                Random p = new Random();
                tuboInferior.Left = this.Width +
                    tuboInferior.Width * p.Next(2, 20);
                placar++;
            }
            if (tuboSuperior.Left < 0 - tuboSuperior.Width * 2)
            {
                Random p = new Random();
                tuboSuperior.Left = this.Width +
                    tuboSuperior.Width * p.Next(2, 20);
                placar++;
            }
            if (bird.Bounds.IntersectsWith(tuboInferior.Bounds) ||
                bird.Bounds.IntersectsWith(tuboSuperior.Bounds) ||
                bird.Top < 0 ||
                bird.Bounds.IntersectsWith(ground.Bounds))
            {
                jogo.Stop();
                lbMensagem.Text = "Voce perdeu!";
            }
            lbPlacar.Text = String.Format("PLACAR: {0}",
                placar.ToString().PadLeft(4, '0'));
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsWhiteSpace(e.KeyChar))
            {
                jogo.Start();
                placar = 0;
                tuboSuperior.Left = this.Width +
                   tuboSuperior.Width * 3;
                tuboInferior.Left = this.Width + tuboInferior.Width * 2;
                bird.Top = this.Height / 2;
                lbMensagem.Text = "Pressione ESC para sair";
            }
        } 
    }
}
