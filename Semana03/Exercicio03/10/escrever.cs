using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[] arquivos = Directory.GetFiles(@"C:\");

            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            
            Console.ReadKey(true);

        }
    }
}