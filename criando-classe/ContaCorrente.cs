namespace criando_classe
{
    public class ContaCorrente
    {
        public Cliente Titular{get;set;}
        public int NumeroAgencia{get;set;}
        public int NumeroConta {get;set;}
        private double saldo = 100;

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