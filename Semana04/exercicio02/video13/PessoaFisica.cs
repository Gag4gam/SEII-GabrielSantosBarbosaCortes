using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video13
{
    public class PessoaFisica : Padrao
    {
        public override void taxaEmprestimo(double valor)
        {
            //throw new NotImplementedException();
            Console.WriteLine("taxa pf: " + valor*0.1);
        }
    }
}