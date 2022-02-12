using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            CalculoArea();
            Console.ReadKey();
        }
        public static void CalculoArea()
        {
            double raio;
            Console.Write("\nDigite o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("A área do circulo é {0:N2}", area);
        }                
    }
}
