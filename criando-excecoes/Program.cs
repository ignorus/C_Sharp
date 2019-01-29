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
            try
            {
                ContaCorrente conta = new ContaCorrente(5,0);
            }
            catch(ArgumentException erro)
            {
                Console.WriteLine("Ocorreu uma excecao do tipo ArgumentException");
                Console.WriteLine(erro.Message);
                
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
            try{
                return numero/divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Excecao com numero " + numero + " e divisor " + divisor);
                throw;
            }
        }
    }
}
