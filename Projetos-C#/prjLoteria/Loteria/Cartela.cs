using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLoteria
{
    class Cartela
    {
        public List<Label> Numeros { get; set; }

        public Cartela(int num)
        {
            Numeros = new List<Label>();

            for (int i = 0; i < num; i++)
            {
                Numeros.Add(new Label());
                Numeros[i].Text = (i + 1).ToString().PadLeft(2, '0');
                if (i == 99) Numeros[i].Text = "00";
            }
        }

        public void Imprimir(Panel p, int lin, int col)
        {
            int ph = 0, pv = 0;
            p.Controls.Clear();
            for (int i = 0; i < Numeros.Count(); i++)
            {
                Numeros[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Numeros[i].ForeColor = Color.Black;
                Numeros[i].BorderStyle = BorderStyle.FixedSingle;
                Numeros[i].AutoSize = false;
                Numeros[i].Width = p.Width / col;
                Numeros[i].Height = p.Height / lin;
                Numeros[i].Font = new Font(Numeros[i].Font.Name, 12);
                if (i % col == 0 && i != 0)
                {
                    pv += (p.Height / lin);
                    ph = 0;
                }

                Numeros[i].Top = pv;
                Numeros[i].Left = ph;
                ph += (p.Width / col);
                p.Controls.Add(Numeros[i]);
                string caminho = Environment.CurrentDirectory + "\\Bola.png";
                Numeros[i].Image = Image.FromFile(caminho);
                Numeros[i].Show();
            }
        }
        public void Sortear(int faixa, int quantidade)
        {
            List<int> lista = new List<int>();
            Random sorteio = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                int numero = sorteio.Next(0, faixa);
                if (lista.Contains(numero))
                {
                    i--;
                    continue;
                }
                lista.Add(numero);
                Thread.Sleep(1);
            }
            foreach (int num in lista)
            {
                Numeros[num].ForeColor = Color.Black;
                Numeros[num].BackColor = Color.DarkOrange;
            }
        }
    }
}
