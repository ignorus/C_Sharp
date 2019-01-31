using App.SRC;
using Xunit;
using System.IO;
using System;

namespace App.test
{
    public class PreparacaoArquivoTest
    {
        [Fact]
        public void SeparadorElementos()
        {
            PreparacaoArquivo preparador = new PreparacaoArquivo();
            string[] textArray;
            string text = "alo;ola;ahh;uhh";
            textArray = preparador.Separar(text);
            Assert.Equal(4,textArray.Length);
        }
        
    }
    
}