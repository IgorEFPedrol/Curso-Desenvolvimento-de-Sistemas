using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_EXTENSO
{
    public class APIExtenso
    {
        public static string Imprimir(int n)
        {
            if (n < 10) return Unidades(n);
            else return "";
        }

        public static string Unidades(int n)
        {
            string[] u = new string[] {
                "zero", "um", "dois", "três",
                "quatro", "cinco", "seis", "oito", "nove"
            };
            return u[n];
        }
    }
}
