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
            TimeSpan tempo;
            DateTime inicio = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("{0}\t Par: {1}\t Primo: {2}\t Perfeito: {3}", i,
                    BibliotecaMatematica.Par(i),
                    BibliotecaMatematica.Primo(i),
                    BibliotecaMatematica.Perfeito(i));
            }
            DateTime fim = DateTime.Now;
            tempo = fim - inicio;
            Console.WriteLine("Tempo de execução: {0} segundos", tempo.TotalSeconds);
            Console.ReadKey();
        }
    }
}
