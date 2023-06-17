using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoSofia.VO;
using MySql.Data.MySqlClient;

namespace AvaliacaoSofia.DAO
{
    public class PFDAO : BaseDAO
    {
        public List<Fisica> ListaPF;

        public Fisica PessoaFisica { get; set; }

        public void Create()
        {
            this.Sql = "INSERT INTO pessoafisica (nome, doc, endereco) VALUES (@nome,@doc,@end)";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@nome", PessoaFisica.Nome));
            Paramt.Add(new MySqlParameter("@doc", PessoaFisica.CPF));
            Paramt.Add(new MySqlParameter("@end", PessoaFisica.Endereco));
            Execute();
        }

        public void Update()
        {
            this.Sql = "UPDATE pessoafisica SET nome = @nome, endereco = @endereco, doc = @cpf WHERE id = @id";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@nome", PessoaFisica.Nome));
            Paramt.Add(new MySqlParameter("@endereco", PessoaFisica.Endereco));
            Paramt.Add(new MySqlParameter("@cpf", PessoaFisica.CPF));
            Paramt.Add(new MySqlParameter("@id", PessoaFisica.Id));
            Execute();
        }

        public void Delete()
        {
            this.Sql = "DELETE FROM pessoafisica WHERE id = @id;";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@id", PessoaFisica.Id));
            Execute();
        }

        public List<Fisica> List()
        {
            ListaPF = new List<Fisica>();
            this.Sql = "SELECT * FROM pessoafisica";
            using (var dr = ExecuteReader())
            {
                while (dr.Read())
                {
                    PessoaFisica = new Fisica();
                    PessoaFisica.Id = Convert.ToInt32(dr["id"]);
                    PessoaFisica.Nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    PessoaFisica.CPF = dr["doc"] != DBNull.Value ? dr["doc"].ToString() : "";
                    PessoaFisica.Endereco = dr["endereco"] != DBNull.Value ? dr["endereco"].ToString() : "";
                    ListaPF.Add(PessoaFisica);

                }
            }
            return ListaPF;
        }
        
    }
}
