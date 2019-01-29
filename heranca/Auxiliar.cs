namespace heranca
{
    public class Auxiliar : Funcionario
    {
        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}