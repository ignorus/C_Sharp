using System;

namespace criando_classe
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaTiago = new ContaCorrente();
           contaTiago.titular = "Tiago";
           Console.WriteLine("O titular da conta e " + contaTiago.titular);
           contaTiago.numeroAgencia = 1000;
           Console.WriteLine("A agencia da conta e " + contaTiago.numeroAgencia);
           contaTiago.numeroConta = 12345;
           Console.WriteLine("O numero da conta e " + contaTiago.numeroConta);
           Console.WriteLine("O saldo atual da conta e " + contaTiago.saldo);
           contaTiago.saldo += 40.0;
           Console.WriteLine("O saldo atual da conta e " + contaTiago.saldo);
           Console.WriteLine(contaTiago.Saque(200.0));
        }
    }
}
