using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio2
{
    public class funcionario : pessoa
    {
        public decimal salario;
        
        public decimal calcularbonus()
        { 
            return salario * 0.10m;
        }
        
        public void exibirdadosfuncionario()
        {
            Console.WriteLine("salario: " + salario);
            Console.WriteLine("bonus: " + calcularbonus());
            Apresentar();
        }
        public funcionario(string nome, int idade, decimal Salario) 
            : base(nome, idade)
        {
            Salario = salario;
        }
    }
}
