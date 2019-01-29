namespace heranca
{
    public abstract class FuncionarioAutenticavel : Funcionario,Autenticavel
    {
        public FuncionarioAutenticavel(string senha,double salario, string cpf) : base(salario, cpf)
        {
            Senha = senha;
        }

        public string Senha { get; private set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}