using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video09
{
    public class Pessoa
    {
        private string nome = "rodolfgo";
        public Pessoa(string nome){
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}