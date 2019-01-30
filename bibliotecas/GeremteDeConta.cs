namespace bibliotecas
{
    public class GeremteDeConta : FuncionarioAutenticavel
    {
         
        public GeremteDeConta(string senha,string cpf) : base(senha,4000, cpf)
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

        public  bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}