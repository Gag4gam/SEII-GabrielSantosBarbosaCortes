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
            
            string[] documentos = File.ReadAllLines(nomeDoArquivo);

            foreach(string documento in documentos)
                Console.WriteLine(documento);

            Console.ReadKey(true);

        }
    }

    internal class List
    {
    }
}