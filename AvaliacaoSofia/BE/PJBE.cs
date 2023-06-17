using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoSofia.VO;
using AvaliacaoSofia.DAO;


namespace AvaliacaoSofia.BE
{
    public class PJBE
    {
        public Juridica Pessoa { get; set; }
        private PJDAO Dao { get; set; }

        public PJBE()
        {
            Dao = new PJDAO();
        }

        public void Create()
        {
            Dao.PessoaJuridica = Pessoa;
            Dao.Create();
        }
        public void Delete()
        {
            Dao.PessoaJuridica = Pessoa;
            Dao.Delete();
        }
        public void Update()
        {
            Dao.PessoaJuridica = Pessoa;
            Dao.Update();
        }

        public List<Juridica> List()
        {
            return Dao.List();
        }
    }
}
