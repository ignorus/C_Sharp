namespace heranca
{
    public class GeremteDeConta : Autenticavel
    {
         public string Senha { get; private set; }
        public GeremteDeConta(string senha,string cpf) : base(4000, cpf)
        {
            Senha = senha;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}