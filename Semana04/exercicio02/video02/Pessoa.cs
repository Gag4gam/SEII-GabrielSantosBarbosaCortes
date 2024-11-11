using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video02
{
    public class Pessoa
    {
        public void apresentar()
        {
            Console.WriteLine("Olá!");
        }
        public void apresentar(string nome)
        {   
            Console.WriteLine("Olá! " + nome);
        }
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Olá!" + nome + " você tem " + idade + " anos!");
        }
    }
}