using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;


namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pasta = "Nova paste";

            Directory.CreateDirectory(pasta);
            
            Console.ReadKey(true);

        }
    }
}