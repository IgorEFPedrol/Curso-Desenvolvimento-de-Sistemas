using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    class Cartela
    {
        public List<Label> Numeros { get; set; }

        public Cartela(int num)
        {
            Numeros = new List<Label>();

            for (int i = 0; i < Numeros.Count(); i++)
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
                
            }
        }
    }
}
