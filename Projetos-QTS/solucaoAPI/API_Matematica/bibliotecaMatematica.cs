using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Matematica
{
    public class BibliotecaMatematica
    {
        public static bool Par(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static bool Primo(int num)
        {
            if (Par(num) && num != 2) return false;
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) cont++;
            }
            return cont == 2 ? true : false;
        }
    }
}
