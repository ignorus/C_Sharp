using System;

namespace App.SRC
{
    class Program
    {
        static void Main(string[] args)
        {
            ArquivoTXT arquivo = new ArquivoTXT();
            PreparacaoArquivo separador = new PreparacaoArquivo();
            OrdenacaoArquivo ordenador = new OrdenacaoArquivo();
            string[] arquvoParaManipular;
            string resposta;
            if(arquivo.AbrirArquivo("/home/tiago-bugan-debs/C_Sharp/ler-arquivo-texto/PastaArquivos/ListaDeTimes.txt"))
            {
                arquvoParaManipular = separador.Separar(arquivo.Text);
                System.Console.WriteLine("Ordenar arquivo em ordem crescente ou decrescente?");
                resposta = System.Console.ReadLine();
                if(resposta.Equals("crescente"))
                {
                    ordenador.OrdenarCrescente(arquvoParaManipular);
                    foreach(string element in arquvoParaManipular)
                    {
                        
                        System.Console.WriteLine("{0} ", element);
                    }
                }

                if(resposta.Equals("decrescente"))
                {
                    ordenador.OrdenarDecrescente(arquvoParaManipular);
                    foreach(string element in arquvoParaManipular)
                    {
                        
                        System.Console.WriteLine("{0} ", element);
                    }
                }
            } 
            
        }

       
    }
}
