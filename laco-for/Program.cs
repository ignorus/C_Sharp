using System;

namespace laco_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("laco for");
            double valorInvestido = 1000.00;
            for(int contadorMes = 1; contadorMes <= 12; contadorMes ++)
            {
                valorInvestido = valorInvestido + valorInvestido*0.0036;
            }
            Console.WriteLine(valorInvestido);
        }
    }
}
