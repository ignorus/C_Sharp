using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heranca!!");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789 -01");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123.456.789 -01");
            roberta.Nome = "Roberta";
            
            GeremteDeConta camila = new GeremteDeConta("123.456.789 -01");
            camila.Nome = "Camila";
            
            Auxiliar igor = new Auxiliar("123.456.789 -01");
            igor.Nome = "Igor";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(igor);
            Console.WriteLine(gerenciador.GetTotalBonificacao());
            
        }
    }
}
