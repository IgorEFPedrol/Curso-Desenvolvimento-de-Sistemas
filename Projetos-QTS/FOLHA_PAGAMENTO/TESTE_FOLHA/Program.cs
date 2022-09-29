using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_FOLHA;
namespace TESTE_FOLHA
{
    class Program
    {
        static List<ICalculoSalario> Empregados;
        static void Main(string[] args)
        {
            Empregados = new List<ICalculoSalario>();
            Empregados.Add(new Funcionario()
            {
                Cod = 1,
                Nome = "JOAO NINGUEM DA SILVA",
                Horas = 160
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 2,
                Nome = "ANA DO CARMO VARGAS",
                Horas = 160
            });
            Empregados.Add(new Estagiario()
            {
                Cod = 3,
                Nome = "RECRUTA",
                Horas = 160,
                Vale = 80
            });
            Empregados.Add(new Estagiario()
            {
                Cod = 4,
                Nome = "INICIANTE",
                Horas = 160,
                Vale = 75
            });
            Empregados.Add(new Estagiario()
            {
                Cod = 5,
                Nome = "ASPIRA",
                Horas = 160,
                Vale = 60
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 6,
                Nome = "ISABELLA DE FREITAS",
                Horas = 160
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 7,
                Nome = "PEDRO SANTIAGO",
                Horas = 160
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 8,
                Nome = "RAQUEL DE ALMEIDA",
                Horas = 160
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 9,
                Nome = "JOSÉ FELÍCIO DA COSTA",
                Horas = 160
            });
            Empregados.Add(new Funcionario()
            {
                Cod = 10,
                Nome = "LUCAS MONTEIRO ROCHA",
                Horas = 160
            });
            Random faixa = new Random();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (ICalculoSalario emp in Empregados)
            {
                emp.Holerite(faixa.Next(18, 35));
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}