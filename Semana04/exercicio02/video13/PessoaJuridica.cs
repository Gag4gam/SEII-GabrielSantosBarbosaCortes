using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video13
{
    public class PessoaJuridica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            
            Console.WriteLine("taxa pf: " + valor*0.2);
        }
        
    }
}