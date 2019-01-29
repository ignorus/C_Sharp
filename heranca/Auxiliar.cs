namespace heranca
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

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