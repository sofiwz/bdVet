using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvaliacaoSofia.VO;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace AvaliacaoSofia.DAO
{
    public class PJDAO : BaseDAO
    {
        public List<Juridica> ListaPJ;
        public Juridica PessoaJuridica { get; set; }

        public void Create()
        {
            this.Sql = "INSERT INTO pessoajuridica (nome,doc,endereco) VALUES (@nome,@doc,@end);";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@nome", PessoaJuridica.Nome));
            Paramt.Add(new MySqlParameter("@doc", PessoaJuridica.CNPJ));
            Paramt.Add(new MySqlParameter("@end", PessoaJuridica.Endereco));
            Execute();
        }

        public void Update()
        {
            this.Sql = "UPDATE pessoajuridica SET nome = @nome, endereco = @endereco, doc = @cpf WHERE id = @id";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@nome", PessoaJuridica.Nome));
            Paramt.Add(new MySqlParameter("@endereco", PessoaJuridica.Endereco));
            Paramt.Add(new MySqlParameter("@cpf", PessoaJuridica.CNPJ));
            Paramt.Add(new MySqlParameter("@id", PessoaJuridica.Id));
            Execute();
        }

        public void Delete()
        {
            this.Sql = "DELETE FROM pessoajuridica WHERE id = @id;";
            Cmd.CommandText = this.Sql;
            Paramt.Add(new MySqlParameter("@id", PessoaJuridica.Id));
            Execute();
        }

        public List<Juridica> List()
        {
            ListaPJ = new List<Juridica>();
            this.Sql = "SELECT * FROM pessoajuridica";
            using (var dr = ExecuteReader())
            {
                while (dr.Read())
                {
                    PessoaJuridica = new Juridica();
                    PessoaJuridica.Id = Convert.ToInt32(dr["id"]);
                    PessoaJuridica.Nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    PessoaJuridica.CNPJ = dr["doc"] != DBNull.Value ? dr["doc"].ToString() : "";
                    PessoaJuridica.Endereco = dr["endereco"] != DBNull.Value ? dr["endereco"].ToString() : "";
                    ListaPJ.Add(PessoaJuridica);

                }
            }
            return ListaPJ;
        }
    }
}
