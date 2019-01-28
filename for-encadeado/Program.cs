using System;

namespace for_encadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for encadeado");
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000.0;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno ++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes ++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao termino do investimento voce tera R$ " + valorInvestido);
        }
    }
}
