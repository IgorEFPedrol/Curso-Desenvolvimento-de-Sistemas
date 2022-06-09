using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora IG = new Calculadora();
        bool EstadoIgual = false;


        private void btn0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn0.Text);
            lbVisor.Text = IG.Visor;
        }

        private void TestarIgual(object sender, EventArgs e)
        {
            if (EstadoIgual == true)
            {
                btnCE_Click(sender, e);
                EstadoIgual = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn1.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn2.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn3.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn4.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn5.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn6.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn7.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn8.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            IG.SetVisor(btn9.Text);
            lbVisor.Text = IG.Visor;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            IG = new Calculadora();
            lbVisor.Text = IG.Visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            IG.Visor = "0";
            lbVisor.Text = IG.Visor;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!IG.Op.Equals("")) IG.Aux2 = 0;
            IG.Op = "+";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IG.Calcular();
            lbVisor.Text = IG.Visor;
            EstadoIgual = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            IG.Op = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            IG.Op = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            IG.Op = "/";
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            IG.InverterSinal();
            lbVisor.Text = IG.Visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            IG.RaizQuadrada();
            lbVisor.Text = IG.Visor;
            EstadoIgual = true;
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            IG.Fracao();
            lbVisor.Text = IG.Visor;
            EstadoIgual = true;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            IG.Quadrado();
            lbVisor.Text = IG.Visor;
            EstadoIgual = true;
        }

        private void btnPontoDecimal_Click(object sender, EventArgs e)
        {
            IG.PontoDecimal();
            lbVisor.Text = IG.Visor;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            IG.Backspace();
            lbVisor.Text = IG.Visor;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            IG.Porcentagem();
            lbVisor.Text = IG.Visor;
            EstadoIgual = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                TestarIgual(sender, e);
                IG.SetVisor(Convert.ToString(e.KeyChar));
                lbVisor.Text = IG.Visor;
                return;
            }
         
            if (e.KeyChar == '+') IG.Op = "+";
            if (e.KeyChar == '-') IG.Op = "-";
            if (e.KeyChar == '*') IG.Op = "*";
            if (e.KeyChar == '/') IG.Op = "/";
            if (e.KeyChar == '=')
            {
                btnCalcular_Click(sender, e);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.Seno();
            lbVisor.Text = IG.Visor;
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.Cosseno();
            lbVisor.Text = IG.Visor;
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.Tangente();
            lbVisor.Text = IG.Visor;
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.PI();
            lbVisor.Text = IG.Visor;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.Euler();
            lbVisor.Text = IG.Visor;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            IG.Logaritmo();
            lbVisor.Text = IG.Visor;
        }
      
    }
}
