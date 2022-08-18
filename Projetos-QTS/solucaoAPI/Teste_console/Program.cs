using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Matematica;

namespace Teste_console
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("{0}\t Par: {1}\t Primo: {2}", i,
                    BibliotecaMatematica.Par(i),
                    BibliotecaMatematica.Primo(i));
            }
            Console.ReadKey();
        }
    }
}
