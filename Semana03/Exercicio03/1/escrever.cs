using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Nome = "arquivo.txt";

            string texto = "Este é um doc de texto.";

            File.WriteAllText(Nome, texto);

            Console.WriteLine("Arquivo criado com sucesso!");

            Console.ReadKey(true);

        }
    }
}