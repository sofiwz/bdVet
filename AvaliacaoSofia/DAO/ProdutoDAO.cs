using AvaliacaoSofia.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSofia.DAO
{
    class ProdutoDAO : BaseDAO
    {
        public List<Produto> ListaProduto;
        public Produto Prod { get; set; }

        public void Create()
        {
            Sql = "INSERT INTO prod (nome, qtd, cliente) VALUES (@nome,@dqtd,@cliente);";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@nome", Prod.Nome));
            Execute();
        }

        public void Update()
        {
            Sql = "UPDATE prod SET nome = @nome, cliente = @cilente, qtd = @qtd WHERE id = @id;";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@nome", Prod.Nome));
            Paramt.Add(new MySqlParameter("@cod", Prod.Id));
            Execute();
        }

        public void Delete()
        {
            Sql = "DELETE FROM prod WHERE id = @id;";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@id", Prod.Id));
            Execute();
        }


        public List<Produto> List()
        {
            ListaProduto = new List<Produto>();
            Sql = "SELECT * FROM produtos";
            using (var dr = ExecuteReader())
            {
                while (dr.Read())
                {
                    Prod = new Produto();
                    Prod.Id = Convert.ToInt32(dr["id"]);
                    Prod.Nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    ListaProduto.Add(Prod);

                }
            }
            return ListaProduto;
        }
    }
}
