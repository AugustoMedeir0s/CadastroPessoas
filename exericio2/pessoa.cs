using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio2
{
    public abstract class pessoa
    {
        public string Nome;
        public int Idade;
    
        public void Apresentar()
        {
            Console.WriteLine("Nome " + Nome);
            Console.WriteLine("Idade: "+ Idade);
        }
        public pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
