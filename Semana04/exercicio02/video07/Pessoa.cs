using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video07
{
    public class Pessoa
    {
        public Pessoa(){
            Console.WriteLine("construtyuor");
        }
        public Pessoa(string nome){
            Console.WriteLine("Ola "+nome);
        }
    }
}