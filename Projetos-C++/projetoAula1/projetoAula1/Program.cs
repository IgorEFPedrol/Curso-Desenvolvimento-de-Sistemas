using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            setup();
            Media();
            Console.ReadKey();
        }

        public static void setup(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("PROGRAMA DE CÁLCULO DA MÉDIA");
        }

        public static void Media()
        { 
            double a = 0;
            double b = 0;
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            double media = (a + b) / 2;
            Console.WriteLine("A média de {0:C2} + {1:C2} = {2:C2} ", a, b, media);
            Console.ReadKey();
        }
    }
}
