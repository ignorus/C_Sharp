namespace heranca
{
    public class GeremteDeConta : Funcionario
    {
        public GeremteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}