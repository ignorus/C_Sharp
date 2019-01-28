using System;

namespace criando_classe
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaTiago = new ContaCorrente();
           Cliente tiago = new Cliente();
           tiago.Nome = "Tiago";
           tiago.CPF = "455.716.688-14";
           tiago.Profissao = "Analista Junior";
           contaTiago.Titular = tiago;
           Console.WriteLine("O titular da conta e " + contaTiago.Titular);
           contaTiago.NumeroAgencia = 1000;
           Console.WriteLine("A agencia da conta e " + contaTiago.NumeroAgencia);
           contaTiago.NumeroConta = 12345;
           Console.WriteLine("O numero da conta e " + contaTiago.NumeroConta);
           Console.WriteLine("O saldo atual da conta e " + contaTiago.Saldo);
           contaTiago.Saldo = 50.0;
           Console.WriteLine("O saldo atual da conta e " + contaTiago.Saldo);
           Console.WriteLine(contaTiago.Saque(100.0));
           Console.WriteLine("O saldo atual da conta e " + contaTiago.Saldo);
           ContaCorrente contaRosa = new ContaCorrente();
           Console.WriteLine(contaTiago.Transferir(150, contaRosa));
           Console.WriteLine("O saldo atual da conta e " + contaTiago.Saldo);
           Console.WriteLine("O saldo atual da conta e " + contaRosa.Saldo);
        }
    }
}
