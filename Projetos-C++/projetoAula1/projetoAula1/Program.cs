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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("PROGRAMA DE CÁLCULO DA MÉDIA");
            double a = 0;
            double b = 0;
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

        }
    }
}
