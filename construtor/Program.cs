using System;

namespace construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Construtores");
            Console.WriteLine(ContaCorrente.TotalDeContas);
            ContaCorrente conta = new ContaCorrente(867,1000);
            Console.WriteLine(ContaCorrente.TotalDeContas);
            ContaCorrente contaTiago = new ContaCorrente(867,1001);
            Console.WriteLine(ContaCorrente.TotalDeContas);
            ContaCorrente contaRosa = new ContaCorrente(867,1002);
            Console.WriteLine(ContaCorrente.TotalDeContas);
        }
    }
}
