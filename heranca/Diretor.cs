namespace heranca
{
    public class Diretor : Autenticavel
    {
        public string Senha { get; private set; }

        public Diretor(string senha,string cpf) : base(5000,cpf)
        {
            Senha = senha;
        }
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }


        public override bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}