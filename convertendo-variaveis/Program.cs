using System;

namespace convertendo_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" realisando cast de variaveis numericas");
            double horas = 15.22;
            Console.WriteLine("sao " + horas + " horas");
            Console.WriteLine(" ou sendo menos preciso " + (int) horas + " horas");
        }
    }
}
