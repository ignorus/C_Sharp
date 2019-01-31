using App.SRC;
using Xunit;
using System.IO;
using System;

namespace App.test
{
    public class AbrirArquivoTest
    {
        [Fact]
        public void AbrirArquivo()
        {
            string text = File.ReadAllText(@"/home/tiago-bugan-debs/C_Sharp/ler-arquivo-texto/PastaArquivos/test.txt");
            string[] textParsed = text.Split(';');
            Console.WriteLine(text);
            Assert.Equal("ahh",textParsed[2]);
            
        }
    }
}