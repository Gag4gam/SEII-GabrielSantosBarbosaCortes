using System;

class Pessoa
{
    //atributos
    public string nome;
    public int idade;

    //metodos
    public void mensagem()
    {
        Console.WriteLine("Ola " +nome+ " voce tem: " +idade+" anos.");
    }

}