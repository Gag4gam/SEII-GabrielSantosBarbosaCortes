using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video11
{
    public class Gerente : Imposto
    {
        public override void valeAlimentacao(double salario){

            Console.WriteLine("desconto gerente va: " + salario*0.15);
        }
        
    }
}