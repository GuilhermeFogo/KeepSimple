using ConfiguracaoAplication.interfaces;
using System;
using System.IO;

namespace ConfiguracaoAplication
{
    public class Configuracao :IConfiguracao
    {

        public string LerArquivo(string nomeJSON)
        {
            using (StreamReader r = new StreamReader(nomeJSON))
            {
                var json = r.ReadToEnd();
                return json;
            }
        }
    }
}
