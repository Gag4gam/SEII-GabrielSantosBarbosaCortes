using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";

            string conteudo = File.ReadAllText(nomeDoArquivo);

            Console.WriteLine("conteudo do arquivo: ");
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");

            File.AppendAllText(nomeDoArquivo, "Um outro arquivo.");

            conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine(conteudo);
            
            Console.ReadKey(true);

        }
    }

    internal class List
    {
    }
}