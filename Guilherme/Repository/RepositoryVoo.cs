using ConfiguracaoAplication.interfaces;
using Guilherme.Modal;
using Guilherme.Repository.Conexao;
using Guilherme.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace Guilherme.Repository
{
    public class RepositoryVoo : IRepositoryVoo
    {
        private IConfiguracao configuracao;
        private string mycon;
        private SQLiteConnection sqlite;

        public RepositoryVoo(IConfiguracao configuracao)
        {
            this.configuracao = configuracao;
            this.mycon = new MyConexao(configuracao).Conectar();
            this.sqlite = new SQLiteConnection(this.mycon);
        }

        public void Deletar(Voo voo)
        {
            this.sqlite.Open();
            string sql = "delete from TB_VOO where id_voo = @id";
            using (var cmd = new SQLiteCommand(sql))
            {
                cmd.Parameters.AddWithValue("@Id", voo.id_Voo);
                cmd.ExecuteNonQuery();

            }
            this.sqlite.Close();
        }

        public DataTable ListarTudo()
        {
            this.sqlite.Open();
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();

            string sql = "select * from TB_VOO";
            using (var cmd = this.sqlite.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                adapter = new SQLiteDataAdapter(cmd.CommandText, this.mycon);
                adapter.Fill(dt);
            }

            this.sqlite.Close();
            return dt;
        }


        public void EditarVoo(Voo voo)
        {
            this.sqlite.Open();
            string sql = "update TB_VOO set data_voo = @data, set custo = @custo, set distancia =  @distancia," +
                " set captura= @captura, set nivelDor = @nivelDor where id_voo = @id";

            using (var cmd = this.sqlite.CreateCommand())
            {

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", voo.id_Voo);
                cmd.Parameters.AddWithValue("@data", voo.Data_Voo);
                cmd.Parameters.AddWithValue("@custo", voo.custo);
                cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                cmd.Parameters.AddWithValue("@captura", voo.captura);
                cmd.Parameters.AddWithValue("@nivelDor", voo.Nivel_Dor);

                cmd.ExecuteNonQuery();

            }
            this.sqlite.Close();
        }



        public void Salvar(Voo voo)
        {
            this.sqlite.Open();
            string sql = "insert into TB_VOO (data_voo, custo, distancia, captura, nivelDor) values(@data, @custo, @distancia, @captura, @nivelDor)";

            using (var cmd = this.sqlite.CreateCommand())
            {

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@data", voo.Data_Voo);
                cmd.Parameters.AddWithValue("@custo", voo.custo);
                cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                cmd.Parameters.AddWithValue("@captura", voo.captura);
                cmd.Parameters.AddWithValue("@nivelDor", voo.Nivel_Dor);

                cmd.ExecuteNonQuery();

            }
            this.sqlite.Close();
        }

        public bool existID(int id)
        {
            this.sqlite.Open();
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();

            string sql = "select id_voo from TB_VOO where id_voo = @id";
            using (var cmd = this.sqlite.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                adapter = new SQLiteDataAdapter(cmd.CommandText, this.mycon);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Voo ListarUmVoo(int id)
        {
            this.sqlite.Open();

            Voo voo = null;
            string sql = "select * from TB_VOO where id_voo = @id";
            using (var cmd = this.sqlite.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                var ler = cmd.ExecuteReader();
                while (ler.Read()){
                    var cod = ler.GetInt32(0);
                    var distancia = ler.GetInt32(1);
                    var data = ler.GetDateTime(2);
                    var custo = ler.GetInt32(3);
                    var captura = ler.GetString(4);
                    var nivel = ler.GetInt32(5);
                    voo = new Voo(cod, data, custo, distancia, captura, nivel);
                }
            }

            this.sqlite.Close();

            return voo;
        }
    }
}
