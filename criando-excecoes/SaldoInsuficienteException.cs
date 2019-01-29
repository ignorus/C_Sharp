using System;

namespace excecao
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double Valor { get; }
        public SaldoInsuficienteException(double saldo, double valor) : this("Tenativa de saque no valor de R$" + valor + " em uma conta com saldo de R$ " +  saldo)
        {
            Saldo = saldo;
            Valor = valor;
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem) {}
        public SaldoInsuficienteException() {}
    }
}