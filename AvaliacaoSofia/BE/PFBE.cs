using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoSofia.VO;
using AvaliacaoSofia.DAO;

namespace AvaliacaoSofia.BE
{
    public class PFBE
    {
        public Fisica pessoa { get; set; }
        private PFDAO dao { get; set; }

        public PFBE()
        {
            dao = new PFDAO();
        }
        
        public void Create()
        {
            dao.PessoaFisica = pessoa;
            dao.Create();
        }
        public void Delete()
        {
            dao.PessoaFisica = pessoa;
            dao.Delete();
        }
        public void Update()
        {
            dao.PessoaFisica = pessoa;
            dao.Update();
        }
        
        public List<Fisica> List()
        {
            return dao.List();
        }
    }
}
