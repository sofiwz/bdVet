using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoSofia.VO;
using MySql.Data.MySqlClient;

namespace AvaliacaoSofia.DAO
{
    public class VendaDAO : BaseDAO
    {
        public List<Venda> ListaProduto;
        public Venda Venda { get; set; }

        public void Create()
        {
            Sql = "INSERT INTO venda (prod, qtd, cliente) VALUES (@prod,@qtd,@cliente);";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@prod", Venda.Nome));
            Paramt.Add(new MySqlParameter("@qtd", Venda.Qtd));
            Paramt.Add(new MySqlParameter("@cliente", Venda.Cliente));
            Execute();
        }

        public void Update()
        {
            Sql = "UPDATE venda SET nome = @prod, cliente = @cilente, qtd = @qtd WHERE cod = @cod;";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@prod", Venda.Nome));
            Paramt.Add(new MySqlParameter("@qtd", Venda.Qtd));
            Paramt.Add(new MySqlParameter("@cliente", Venda.Cliente));
            Paramt.Add(new MySqlParameter("@cod", Venda.Cod));
            Execute();
        }

        public void Delete()
        {
            Sql = "DELETE FROM venda WHERE cod = @cod;";
            Cmd.CommandText = Sql;
            Paramt.Add(new MySqlParameter("@cod", Venda.Cod));
            Execute();
        }
        
       
        public List<Venda> List()
        {
            ListaProduto = new List<Venda>();
            Sql = "SELECT * FROM venda";
            using (var dr = ExecuteReader())
            {
                while (dr.Read())
                {
                    Venda = new Venda();
                    Venda.Cod = Convert.ToInt32(dr["cod"]);
                    Venda.Nome = dr["prod"] != DBNull.Value ? dr["prod"].ToString() : "";
                    Venda.Qtd = Convert.ToInt32(dr["qtd"] != DBNull.Value ? dr["qtd"] : 0);
                    Venda.Cliente = dr["cliente"] != DBNull.Value ? dr["cliente"].ToString() : "";
                    ListaProduto.Add(Venda);

                }
            }
            return ListaProduto;
        }
    }

}
