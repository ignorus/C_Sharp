using System;

namespace variavel_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 19;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2; 

            if(idade >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Nao pode entrar");
            }
        }
    }
}
