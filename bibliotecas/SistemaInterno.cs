using System;

namespace bibliotecas
{
    public class SistemaInterno
    {
        public void Logar(Autenticavel funcionario, string senha)
        {
            if(funcionario.Autenticar(senha))
            {
                Console.WriteLine("Seja bem vindo!!!");
                return;
            }
            else
            Console.WriteLine("Senha incorreta!!");
            return;
        }
    }
    
}