using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio2
{
    public class Cliente : pessoa
    {
        public string CodigoCliente;

        public void ExibirDadosCLientes()
        {
            Console.WriteLine("COdigo do cliente: " + CodigoCliente);
            Apresentar();
        }

        public Cliente(string nome, int idade, string codigoCliente)
            : base(nome, idade)
        {
            codigoCliente = CodigoCliente;
        }
    }
}
