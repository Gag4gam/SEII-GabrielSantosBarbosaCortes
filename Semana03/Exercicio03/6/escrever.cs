using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";
            
            File.WriteAllText(nomeDoArquivo, "Algum texto.");

            Console.WriteLine(File.Exists(nomeDoArquivo));

            Console.ReadKey(true);

        }
    }

    internal class List
    {
    }
}