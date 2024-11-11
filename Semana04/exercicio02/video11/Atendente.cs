using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video11
{
    public class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario){

            Console.WriteLine("desconto atentende va: " + salario*0.12);
        }
        
    }
}