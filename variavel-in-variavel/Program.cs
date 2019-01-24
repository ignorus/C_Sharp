using System;

namespace variavel_in_variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 23;
            int idaderef = idade;
            idade += 10;
            Console.WriteLine(idaderef);
            Console.WriteLine(idade);
        }
    }
}
