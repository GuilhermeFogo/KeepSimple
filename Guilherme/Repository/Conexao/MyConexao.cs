using ConfiguracaoAplication.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guilherme.Repository.Conexao
{
    public class MyConexao
    {
        private IConfiguracao configuracao;
        private string conn;
        public MyConexao(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            var arquivo = this.configuracao.LerArquivo("C:/Users/Guilherme/Desktop/teste keep simple/Guilherme/appsettings1.json");
            var connectionString = JsonConvert.DeserializeObject<Conn>(arquivo);
            this.conn = connectionString.ConnectionStrings;
        }

        public string Conectar()
        {
            return this.conn;
        }   
    }


}
    class Conn
    {
        public string ConnectionStrings { get; set; }
    }
