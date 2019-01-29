namespace heranca
{
    public class Diretor : Funcionario
    {
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}