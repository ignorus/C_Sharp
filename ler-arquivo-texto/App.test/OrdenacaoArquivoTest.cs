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
    }
}