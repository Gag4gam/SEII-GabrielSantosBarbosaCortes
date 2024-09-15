using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string diretorio = "pasta";

            if(Directory.Exists(diretorio))
            {
                Console.WriteLine("O diretorio existe!");
            }else
            {
                Console.WriteLine("O diretorio nao existe!");
            }

            Console.ReadKey(true);

        }
    }
}