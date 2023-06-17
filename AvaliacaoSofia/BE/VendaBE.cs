using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoSofia.VO;
using AvaliacaoSofia.DAO;

namespace AvaliacaoSofia.BE
{
    class VendaBE
    {
        public Venda Venda { get; set; }
        private VendaDAO Dao { get; set; }

        public VendaBE()
        {
            Dao = new VendaDAO();
        }

        public void Create()
        {
            Dao.Venda = Venda;
            Dao.Create();
        }
        public void Delete()
        {
            Dao.Venda = Venda;
            Dao.Delete();
        }
        public void Update()
        {
            Dao.Venda = Venda;
            Dao.Update();
        }
        public List<Venda> List()
        {
            return Dao.List();
        }

    }
}
