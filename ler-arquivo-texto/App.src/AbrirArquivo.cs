using System;
using System.IO;

namespace App.SRC
{
    public class  ArquivoTXT
    {
        public string Text { get; private set; }
        public bool AbrirArquivo(string path)
        {
            try
            {
                Text = File.ReadAllText(path).Trim();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
    }
}