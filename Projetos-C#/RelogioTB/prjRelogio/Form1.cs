﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRelogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = Environment.CurrentDirectory + "\\fundo.png";
        Bitmap fundo;
        Graphics g;

        int hora;
        int min;
        int seg;
        int xseg = 0, yseg = 0;
        int xmin = 0, ymin = 0;
        int xhora = 0, yhora = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            fundo = new Bitmap(pbRelogio.Width, pbRelogio.Height);
            pbRelogio.Image = fundo;
            g = Graphics.FromImage(fundo);
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            DateTime bios = DateTime.Now;
            hora = bios.Hour;
            min = bios.Minute;
            seg = bios.Second;
            DesenharFundo();
            DesenharPonteiroSegundo();
            DesenharPonteiroMinuto();
            DesenharPonteiroHora();
            DesenharCentro();
            DesenharDigital();
            pbRelogio.CreateGraphics().DrawImage(fundo, 0, 0);
        }

        private void DesenharDigital()
        {
            SolidBrush corSolida = new SolidBrush(Color.Black);
            g.DrawString(DateTime.Now.ToLongTimeString(), new Font("Arial", 12), corSolida, 125, 50);
        }

        private void DesenharFundo()
        {
            g.DrawImage(Image.FromFile(path), 0, 0, pbRelogio.Width, pbRelogio.Height);
        }

        private void DesenharCentro()
        {
            SolidBrush corSolida = new SolidBrush(Color.Red);
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            g.FillEllipse(corSolida, cx - 10, cy - 10, 20, 20);
            corSolida.Color = Color.White;
            g.FillEllipse(corSolida, cx - 8, cy - 8, 16, 16);
        }

        private void DesenharPonteiroHora()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 75;
            if (hora > 12) hora = hora - 12;
            double angulo = -90 + (hora * 30);
            angulo += -90 + (hora * 30);
            Pen caneta = new Pen(Color.White, 7);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xhora, cy + yhora);
            double rad = Math.PI * angulo / 180;
            xhora = (int)(raio * Math.Cos(rad));
            yhora = (int)(raio * Math.Sin(rad));
            caneta.Color = Color.Black;
            g.DrawLine(caneta, cx, cy, cx + xhora, cy + yhora);
        }

        private void DesenharPonteiroMinuto()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 90;
            double angulo = -90 + (min * 6);
            Pen caneta = new Pen(Color.White, 4);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xmin, cy + ymin);
            double rad = Math.PI * angulo / 180;
            xmin = (int)(raio * Math.Cos(rad));
            ymin = (int)(raio * Math.Sin(rad));
            caneta.Color = Color.Blue;
            g.DrawLine(caneta, cx, cy, cx + xmin, cy + ymin);
        }

        private void DesenharPonteiroSegundo()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 110;
            double angulo = -90 + (seg * 6);
            Pen caneta = new Pen(Color.Transparent, 4);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xseg, cy + yseg);
            double rad = Math.PI * angulo / 180;
            xseg = (int)(raio * Math.Cos(rad));
            yseg = (int)(raio * Math.Sin(rad));
            caneta.Color = Color.Red;
            g.DrawLine(caneta, cx, cy, cx + xseg, cy + yseg);

        }
    }
}
