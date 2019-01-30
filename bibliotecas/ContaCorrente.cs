using System;

namespace bibliotecas
{
     public class ContaCorrente
    {
        public Cliente Titular{get;set;}
        public static int TotalDeContas{get; private set;}
        public int NumeroAgencia{get;}
        public int NumeroConta {get;}
        private double saldo = 100;

        public static double TaxaOperacao{get; private set;}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {}
                saldo = value;
            }
        }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaqueNaoPermitido { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento numero da agencia deve ser maior que 0.",nameof(NumeroAgencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero da conta deve ser maior que 0.",nameof(NumeroConta));
            }
            NumeroAgencia = agencia;
            NumeroConta = numero;
            TotalDeContas ++;
            TaxaOperacao = 30/TotalDeContas;

        }

        public void Saque (double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Nao eh possivel realizar a operacao desejada com valores menores que 0.", nameof(valor));
            }
            if(this.saldo < valor)
            {
                ContadorSaqueNaoPermitido++;
                throw new SaldoInsuficienteException(this.Saldo, valor);
            }
            
            this.saldo -= valor;
                
        }

        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public void Transferir (double valor, ContaCorrente contaDestino)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Nao eh possivel realizar a operacao desejada com valores menores que 0.", nameof(valor));
            }
            try
            {
                Saque(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas ++;
                throw new OperacaoFinanceiraExecption("Operacao nao realizada",ex);
            }   
            contaDestino.Depositar(valor);
        }
    }
}