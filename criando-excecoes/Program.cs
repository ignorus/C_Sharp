using System;

namespace excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excecoes");
            try
            {
                ContaCorrente conta = new ContaCorrente(5,1244523);
                ContaCorrente conta2 = new ContaCorrente(5,723845);
                conta.Depositar(50);
                conta.Saque(50);
                conta.Transferir(-510,conta2);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Ocorreu uma excecao do tipo ArgumentException");
                Console.WriteLine("O parametro que esta com problema eh: " + e.ParamName);
                Console.WriteLine(e.Message);  
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
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
