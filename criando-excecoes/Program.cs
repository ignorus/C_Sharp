using System;

namespace construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excecoes");
            ContaCorrente conta = new ContaCorrente(867,1000);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
