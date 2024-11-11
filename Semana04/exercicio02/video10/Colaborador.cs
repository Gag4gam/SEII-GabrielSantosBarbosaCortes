using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video10
{
    public class Colaborador : Pessoa
    {
        private double salario;
        private void mensagemColaborador(){
            Console.WriteLine("Salario: " + salario);

        }
        public Colaborador(string nome, int idade, double salario){
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            mensagemPessoa();
            mensagemColaborador();
        }
    }   
}