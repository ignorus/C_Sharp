namespace heranca
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor( string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new System.NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new System.NotImplementedException();
        }
    }
}