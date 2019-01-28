namespace heranca
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}