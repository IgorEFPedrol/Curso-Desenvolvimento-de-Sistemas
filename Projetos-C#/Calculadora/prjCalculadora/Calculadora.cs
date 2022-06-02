using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadora
{
    class Calculadora
    {
        public string Visor { get; set; }
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }
        private string op;
        public string Op
        {
            get { return op; }
            set {
                Aux1 = Double.Parse(Visor);
                Visor = "0";
                op = value;
            }
        }

        public Calculadora()
        {
            Visor = "0";
            Aux1 = 0f;
            Aux2 = 0f;
            Op = "";
        }

        public void SetVisor(string digito)
        {
            if (Visor.Equals("0"))
                Visor = digito;
            else Visor += digito;
        }

        public void Calcular()
        {
            if (Aux2 == 0) Aux2 = Double.Parse(Visor);
            if (Op.Equals("+")) Aux1 += Aux2;
            if (Op.Equals("-")) Aux1 -= Aux2;
            if (Op.Equals("*")) Aux1 *= Aux2;
            if (Op.Equals("/")) Aux1 /= Aux2;
            Visor = Aux1.ToString();
        }

        public void InverterSinal()
        {
            double num = Double.Parse(Visor) * -1;
            Visor = num.ToString();
        }

        public void RaizQuadrada()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Sqrt(num).ToString();
        }
    }        
}            
