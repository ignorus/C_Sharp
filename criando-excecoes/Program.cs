using System;

namespace construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excecoes");
            try
            {
                Metodo();
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine(erro.Message);
                Console.WriteLine("excecao tratada");
            }
        }

        static void Metodo()
        {
            TestarDivisao(0);
        }

        static void TestarDivisao(int divisor)
        {
            Dividir(10,divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);

            return numero/divisor;
        }
    }
}
