namespace heranca
{
    public class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(5000,cpf)
        {

        }
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