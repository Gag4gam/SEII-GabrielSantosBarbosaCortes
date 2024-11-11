using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video13
{
    public abstract class Padrao
    {
        public abstract void taxaEmprestimo(double valor);
        public void calculoPoupanca(double valor, double taxa){
            Console.WriteLine("Ganhos poupança: " + valor*taxa);
            
        }


        
    }
}