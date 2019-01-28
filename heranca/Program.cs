using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heranca!!");
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario tiago = new Funcionario();
            tiago.Nome = "Tiago";
            tiago.CPF = "123.123.456-20";
            tiago.Salario = 250;
            gerenciador.Registrar(tiago);
            Console.WriteLine(tiago.Nome);
            Console.WriteLine(tiago.GetBonificacao());
            Diretor olavo = new Diretor();
            olavo.Nome = "Olavo";
            olavo.CPF = "345.137.981-24";
            olavo.Salario = 1000;
            gerenciador.Registrar(olavo);
            Console.WriteLine(olavo.Nome);
            Console.WriteLine(olavo.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

        }
    }
}
