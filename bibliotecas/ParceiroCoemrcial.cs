namespace bibliotecas
{
    public class ParceiroCoemrcial : Autenticavel
    {

        public ParceiroCoemrcial(string senha)
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