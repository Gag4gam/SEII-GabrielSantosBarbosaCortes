using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video11
{
    public class Imposto
    {
        public virtual void valeAlimentacao(double salario){

            Console.WriteLine("desconto va: " + salario*0.1);
        }
        public void valeTransporte(double salario){

            Console.WriteLine("desconto vt: " + salario*0.06);
        }
    }
}