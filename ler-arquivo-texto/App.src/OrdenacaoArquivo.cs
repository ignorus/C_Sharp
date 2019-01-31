using System;

namespace App.SRC
{
    public class OrdenacaoArquivo
    {
        public void OrdenarCrescente(string[] textArray)
        {
            Array.Sort(textArray);
            return;
        }

        public void OrdenarDecrescente(string[] textArray)
        {
            Array.Sort(textArray);
            Array.Reverse(textArray);
            return;
        }
    }
}