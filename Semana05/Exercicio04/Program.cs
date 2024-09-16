using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exercicio04
{
    class Program
    {
        static async Task Main(string[] arg)
        {
            string URL =  "https://emojicombos.com/cat";

            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            var tasks = new List<Task> { SummonDogLocally(), SummonDogFromURL(URL)};
            await Task.WhenAll(tasks);

            sw.Stop();
            Console.WriteLine("We are done here.... " + sw.ElapsedMilliseconds);
        }

        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog locally...");

            string dogText = await File.ReadAllTextAsync("dog.txt");

            Console.WriteLine($"2. Summoning Dog locally \n{dogText}");

        }
        
        static async Task SummonDogFromURL(string URL)
        {
            Console.WriteLine("1. Summoning Dog from URL...");

            using(var htttpCLient = new HttpClient())
            {
                string result = await htttpCLient.GetStringAsync(URL);

                Console.WriteLine($"2. Dog Summoning from URL \n{result}");
            }

        }
    
    }
}