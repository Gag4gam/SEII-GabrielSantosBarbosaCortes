using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace Exercicio02
{
    class Program
    {
        public static void Main(string[] args)
        {

            //instanciando objeto
            Pessoa obj = new Pessoa();
            obj.nome  = "Gabriel";
            obj.idade = 21;
            obj.mensagem();

        }
    }
}