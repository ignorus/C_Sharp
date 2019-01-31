using System;

namespace App.SRC
{
    public class PreparacaoArquivo
    {
        public string[] Separar(string text)
        {
            return text.Split(";");
        }
    }
}