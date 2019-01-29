using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heranca!!");
            //CalcularBonificacao();
            UsarSistema();

        }

        public static void UsarSistema()
        {
            Diretor roberta = new Diretor("123","435.718.925-05");
            roberta.Nome = "Roberta";
            
            GeremteDeConta camila = new GeremteDeConta("abc","637.578.183-20");
            camila.Nome = "Camila";

            SistemaInterno sistema = new SistemaInterno();
            sistema.Logar(roberta,"123");
            sistema.Logar(camila,"123");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789 -01");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123","435.718.925-05");
            roberta.Nome = "Roberta";
            
            GeremteDeConta camila = new GeremteDeConta("abc","637.578.183-20");
            camila.Nome = "Camila";
            
            Auxiliar igor = new Auxiliar("367.568.591-36");
            igor.Nome = "Igor";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(igor);
            Console.WriteLine("A bonifacacao total do mes foi de R$ " + gerenciador.GetTotalBonificacao());
            
        }
    }
}
