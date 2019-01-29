namespace construtor
{
    public class ContaCorrente
    {
        public Cliente Titular{get;set;}
        public static int TotalDeContas{get; private set;}
        public int NumeroAgencia{get;set;}
        public int NumeroConta {get;set;}
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

        public ContaCorrente(int agencia, int numero)
        {
            NumeroAgencia = agencia;
            NumeroConta = numero;
            TotalDeContas ++;
            TaxaOperacao = 30/TotalDeContas;

        }

        public bool Saque (double valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}