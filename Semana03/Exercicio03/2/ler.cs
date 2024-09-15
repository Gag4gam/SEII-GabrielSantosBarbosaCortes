using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program2
    {
        public static void Main2(string[] args)
        {
            string arquivo = "arquivo.txt";

            string texto = File.ReadAllText(arquivo);

            Console.WriteLine("conteudo do arquivo: " + texto);

            Console.ReadKey(true);

        }
    }
}