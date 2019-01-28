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
         }
    }
}
