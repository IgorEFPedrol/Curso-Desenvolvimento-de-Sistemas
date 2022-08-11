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
        Graphics G { get; set; }
        public RetGrafico(Graphics G)
        {
            this.G = G;
        }
        public void Desenhar(modelo.RetMatematico ret, double
            escala)
        {
            G.PageUnit = GraphicsUnit.Millimeter;
            G.PageScale = (float)(0.01f * escala);
            G.Clear(Color.White);
            Pen p = new Pen(Color.Red, 2);
            p.DashStyle = DashStyle.DashDotDot;
            G.DrawRectangle(p, 10, 10,
                (int)ret.C * 10, (int)ret.A * 10);

            LinearGradientBrush gradiente = new LinearGradientBrush(
                new Point(0, 0), new Point(10, 10),
                Color.DarkSlateBlue, Color.BlueViolet
                );
            G.FillRectangle(gradiente, 10, 10,
               (int)ret.C * 10, (int)ret.A * 10);
            SolidBrush cor = new SolidBrush(Color.Black);
            G.DrawString("Área:" + ret.Area() + " cm quad",
                new Font("Arial", 14), cor,
                (10 + (int)ret.C * 10) / 2,
                (10 + (int)ret.A * 10) / 2);
        }
    }
}