using Xunit;
using App.SRC;

namespace App.Test
{
    public class OrdenacaoArquivoTest
    {
        [Fact]
        public void OrdenarCrescenteTest()
        {
            OrdenacaoArquivo ordenador = new OrdenacaoArquivo();
            string[] textArray = new string[] {"ola","uhh","ahh","alo"};
            ordenador.OrdenarCrescente(textArray);
            Assert.Equal("ahh",textArray[0]);
            
        }

        [Fact]
        public void OrdenarDecrescenteTest()
        {
            OrdenacaoArquivo ordenador = new OrdenacaoArquivo();
            string[] textArray = new string[] {"ahh","alo","uhh","ola"};
            ordenador.OrdenarDecrescente(textArray);
            Assert.Equal("uhh",textArray[0]);
        }
    }
}