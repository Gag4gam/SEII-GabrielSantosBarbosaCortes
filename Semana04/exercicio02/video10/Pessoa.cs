using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video10
{
    public class Pessoa
    {
        protected string? nome;
        protected int idade;

        protected void mensagemPessoa(){
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("idade: " + idade);

        }
    }
}