using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio02
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;
        public Pessoa(string nome, string sobrenome,int idade){
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
        }
    }
}