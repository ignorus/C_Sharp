namespace bibliotecas
{
    public class Diretor : FuncionarioAutenticavel
    {
    

        public Diretor(string senha,string cpf) : base(senha,5000,cpf)
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


        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}