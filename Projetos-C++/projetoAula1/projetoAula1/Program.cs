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
            ConsoleKeyInfo tecla;
            do
            {
                setup();
                Console.WriteLine("1 - Media Aritmetica");
                Console.WriteLine("2 - Media Geométrica");
                Console.WriteLine("<ESC> - Sair...");
                Console.Write("Selecionar opção: ");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.D1 || tecla.Key == ConsoleKey.NumPad1) Media();
                if (tecla.Key == ConsoleKey.D2 || tecla.Key == ConsoleKey.NumPad2) Geometrica();
            } while (tecla.Key != ConsoleKey.Escape);
           
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
            Console.Write("\nDigite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A média de {0:C2} + {1:C2} = {2:C2} ", a, b, (a + b) / 2);
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
        }

        public static void Geometrica()
        {
            double a = 0;
            double b = 0;
            Console.Write("\nDigite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A média de {0:N2} + {1:N2} = {2:N2}");
            Console.ReadKey();
        }
    }
}
