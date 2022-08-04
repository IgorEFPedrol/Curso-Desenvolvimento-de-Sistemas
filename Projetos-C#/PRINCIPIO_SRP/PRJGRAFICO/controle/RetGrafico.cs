using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJGRAFICO.controle
{
    class RetGrafico
    {
        private Graphics graphics;

        Graphics G { get; set; }
        public RetGrafico(Graphics G)
        {
            this.G = G;
        }
        public void Desenhar(modelo.RetMatematico ret)
        {
            G.PageUnit = GraphicsUnit.Millimeter;
            G.Clear(Color.White);
            Pen p = new Pen(Color.Black, 2);
            p.DashStyle = DashStyle.DashDotDot;
            G.DrawRectangle(p, 10, 10,
                (int)ret.C * 10, (int)ret.A * 10);
            SolidBrush cor = new SolidBrush(Color.Black);
            G.DrawString("Área: " + ret.Area() + "cm",
                new Font("Arial", 14), cor,
                (10 + (int)ret.C * 10) / 2,
                (10 + (int)ret.A * 10) / 2); 

        }
    }
}
