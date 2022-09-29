using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    class Funcionario:ICalculoSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Horas { get; set; }

        public Funcionario(int Cod, string Nome, double Horas)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Horas = Horas;
        }
        public Funcionario():this(0, "", 0f)
        {

        }
        public double Calcular(double SalarioHora)
        {
            double sb = Horas * SalarioHora;
            return sb;
        }
        public double Desconto(double Salario)
        {
            double valor = Salario * 0.02;
            return valor;
        }
    }
}
