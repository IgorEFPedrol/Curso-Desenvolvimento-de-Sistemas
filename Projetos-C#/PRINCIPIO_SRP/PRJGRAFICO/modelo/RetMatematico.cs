using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJGRAFICO.modelo
{
    class RetMatematico
    {
        public double A {get; set; }
        public double C { get; set; }
        public RetMatematico(double A, double C)
        {
            this.A = A;
            this.C = C;
        }
        public double Area()
        {
            return A * C;
        }
    }
}
