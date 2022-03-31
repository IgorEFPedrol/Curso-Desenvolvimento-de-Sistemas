using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>();
        List<string> dicas = new List<string>();

        Forca jogo;
        Label[] Letras;
        int Erro = 0;
        SoundPlayer som;

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarLista();
            jogo = new Forca(lista);
            jogo.Sortear();
            DesenharPalavra(jogo.DevolvePalavra());
            som = new SoundPlayer();
            som.SoundLocation = Environment.CurrentDirectory + "\\fundo.wav";
            som.PlayLooping();
            lbDica.Text = "DICA: " + dicas[jogo.Pos];
        }

        private void CarregarLista()
        {
            string file = Environment.CurrentDirectory + "\\lista.txt";
            StreamReader st = new StreamReader(file,Encoding.UTF8);
            int qtd = File.ReadAllLines(file).Count();
            for (int i = 0; i < qtd; i++)
            {
                string linha = st.ReadLine();
                string[] campo = linha.Split(',');
                lista.Add(campo[0]);
                dicas.Add(campo[1]);
            }
            st.Close();
        }

        private void DesenharPalavra(string p)
        {
            int qtd = p.Length;
            Letras = new Label[qtd];
            int cx = 10;
            int cy = 10;
            for (int i = 0; i < qtd; i++)
            {
                Letras[i] = new Label();
                Letras[i].Text = "?";
                Letras[i].AutoSize = false;
                Letras[i].Width = 30;
                Letras[i].Height = 30;
                Letras[i].BorderStyle = BorderStyle.FixedSingle;
                Letras[i].ForeColor = Color.Blue;
                Letras[i].BackColor = Color.White;
                Letras[i].TextAlign = ContentAlignment.MiddleCenter;
                if (i % 5 == 0 && i != 0)
                {
                    cy += 35;
                    cx = 10;
                }
                Letras[i].Top = cy;
                Letras[i].Left = cx;
                cx += 35;
                pnPalavra.Controls.Add(Letras[i]);
                Letras[i].Show();
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
           DesenharLetra(txtLetra.Text);
           txtLetra.Focus();
           txtLetra.SelectAll();
        }

        private void DesenharLetra(string letra)
        {
            string p = jogo.DevolvePalavra();
            bool achei = false;
            if (lbLetras.Text.Contains(letra))
            {
                MessageBox.Show("Letra já digitada");
                return;
            }
            lbLetras.Text += letra + " ";
            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i, 1).Equals(letra))
                {
                    Letras[i].Text = letra;
                    achei = true;
                }
            }

            if (achei == false)
            {
                Erro++;
                DesenharBoneco();
            }

            if (Erro == 6)
            {
                timer1.Stop();
                Derrota();
                lbCronometro.Text = "120";
                timer1.Start();
            }

            Vitoria();
        }

        private void Vitoria()
        {
            string p = jogo.DevolvePalavra();
            string tmp = "";
            foreach (Label letra in Letras)
            {
                tmp += letra.Text;
            }
            if (p.Equals(tmp))
            {
                timer1.Stop();
                MessageBox.Show("Voce Venceu");
                NovoJogo();
                lbCronometro.Text = "120";
                timer1.Start();
                lbCronometro.ForeColor = Color.White;
            }
        }

        private void Derrota()
        {
            MessageBox.Show("Voce perdeu. A palavra era " + jogo.DevolvePalavra());
            NovoJogo();
            lbCronometro.ForeColor = Color.White;
        }

        private void NovoJogo()
        {
            Erro = 0;
            pnPalavra.Controls.Clear();
            pbBoneco.Image = null;
            jogo.Sortear();
            DesenharPalavra(jogo.DevolvePalavra());
            lbLetras.Text = "";
            lbDica.Text = "DICA: " + dicas[jogo.Pos];
        }

        private void DesenharBoneco()
        {
            string arquivo = Environment.CurrentDirectory + "\\imagens\\forca" + Erro + ".png";
            pbBoneco.Image = Image.FromFile(arquivo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int seg = Int16.Parse(lbCronometro.Text);
            seg--;
            lbCronometro.Text = seg.ToString();
            if (seg <= 60)
            {
                lbCronometro.ForeColor = Color.Yellow;
            }
            if (seg <= 40)
            {
                Console.Beep();
                lbCronometro.ForeColor = Color.Orange;
            }
            if (seg <= 15)
            {
                Console.Beep();
                lbCronometro.ForeColor = Color.Red;
            }
            if (seg <= 0)
            {
                timer1.Stop();
                Derrota();
                lbCronometro.Text = "120";
                lbCronometro.ForeColor = Color.White;
                timer1.Start();
            }
        }

        private void btnNovojogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
            lbCronometro.Text = "120";
        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(
                     Keys.Enter))
                {
                    btnJogar_Click(sender, e);
                }
            }
        }
    }
}
