namespace heranca
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            
        }

        public override double GetBonificacao()
        {
            return 0;
        }

        public abstract bool Autenticar(string senha);
    }
}