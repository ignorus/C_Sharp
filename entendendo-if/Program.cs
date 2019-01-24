using System;

namespace entendendo_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazendo um if");

            int idade = 14;
            int numeroPessoas = 1;
             if (idade > 18)
             {
                 Console.WriteLine("Pode entrar");
             }
             else
             {
                 if(numeroPessoas >= 2)
             {
                 Console.WriteLine("Sejam bem vindos");
             }
             else{
                Console.WriteLine("volte para casa");
             }
             }
        }
    }
}
