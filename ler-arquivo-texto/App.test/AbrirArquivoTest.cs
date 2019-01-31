using App.SRC;
using Xunit;
using System.IO;
using System;

namespace App.test
{
    public class AbrirArquivoTest
    {
        [Fact]
        public void AbrirArquivoTXTTest()
        {
            ArquivoTXT abrir = new ArquivoTXT();
            Assert.True(abrir.AbrirArquivo("/home/tiago-bugan-debs/C_Sharp/ler-arquivo-texto/PastaArquivos/test.txt"));
        }

        [Fact]
        public void DarErroAoMandarAbrirArquivoInexistente()
        {
            ArquivoTXT abrir = new ArquivoTXT();
            Assert.False(abrir.AbrirArquivo("/home/tiago-bugan-debs/C_Sharp/ler-arquivo-texto/PastaArquivos/test.tvt"));
        }
    }
}