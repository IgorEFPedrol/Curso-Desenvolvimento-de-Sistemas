using API_EXTENSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_EXTENSO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime inicio = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("{0} = {1}",
                    i, APIExtenso.Imprimir(i));
            }
            DateTime fim = DateTime.Now;
            TimeSpan tempo = new TimeSpan();
            tempo = fim - inicio;
            Console.WriteLine("Tempo: {0}", tempo.TotalSeconds);
            Console.ReadKey();
        }
    }
}
