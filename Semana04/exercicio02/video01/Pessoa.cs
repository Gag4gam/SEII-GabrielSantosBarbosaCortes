using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video01
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public void imprime()
        {
            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");
        }
    }
}