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
        public string Op { get; set; }

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
    }        
}            
