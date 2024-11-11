using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace video03
{
    public class Aluno
    {
        public string nome;
        public int nota1,nota2;

        public double media()
        {
            return (nota1 + nota2)/2;
        }

        public string situacao(double media)
        {
            return media >= 6 ? "aprovado" : "reprovado";
        }

        public void mensagem(){

            double obterMedia = media();
            string oberSituacao = situacao(obterMedia);
            Console.WriteLine(nome + " está " + oberSituacao + " com media " + obterMedia);
        }
    }
}