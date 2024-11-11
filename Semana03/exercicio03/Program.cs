using System;
using System.IO;

namespace CScurso {
class Program
{
    public static void Main(string[] args)
    {   string nome_arquivo = "arquivo.txt";
        string texto = "meutexto";
        File.WriteAllText(nome_arquivo,texto);
    Console.WriteLine("arquivo criado!");
        
        
       string[] documentos = {"linha2","linha3"};
        
        File.WriteAllLines(nome_arquivo,documentos);
        string[] texto1 = File.ReadAllLines(nome_arquivo);
        foreach(string linha in texto1);
        Console.WriteLine(texto1);
        Console.ReadKey(true);
    }

}


}
