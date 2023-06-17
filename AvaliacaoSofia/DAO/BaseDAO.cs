using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AvaliacaoSofia.DAO
{
    public class BaseDAO
    {
        public string ConnectionString = "server = localhost; uid = root; pwd = ''; database = avaliacao;";
        public MySqlConnection Conex { get; set; }
        public MySqlCommand Cmd { get; set; }
        public MySqlDataAdapter Adapt { get; set; }
        public string Sql { get; set; }
        public List<MySqlParameter> Paramt { get; set; }

        public BaseDAO()
        {
            if (Conex == null)
            {
                Conex = new MySqlConnection(ConnectionString);
            }
            Cmd = new MySqlCommand();
            Adapt = new MySqlDataAdapter();
            Paramt = new List<MySqlParameter>();
        }

        public void Execute()
        {
            try
            {
                Conex.Open();
                Cmd = new MySqlCommand(Sql, Conex);
                foreach (var item in Paramt)
                {
                    Cmd.Parameters.Add(item);
                }
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código: " + ex.Message);
            }
        }

        public MySqlDataReader ExecuteReader()
        {
            try
            {
                Cmd = new MySqlCommand(Sql, Conex);
                Conex.Open();
                return this.Cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Conex.Dispose();
                throw new Exception("Erro no Código: " + ex.Message);
            }
        }
    }
}
