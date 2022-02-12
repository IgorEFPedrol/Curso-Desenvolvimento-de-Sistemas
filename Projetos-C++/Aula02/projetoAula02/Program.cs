using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projetoAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("ÁREA DO CIRCULO");
            for (int i = 1; i <= 50; i++)
            {
                CalculoArea(i);
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
        public static void CalculoArea(double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("A área do circulo de raio {0} é {1:N2}",raio , area);
        }                
    }
}
