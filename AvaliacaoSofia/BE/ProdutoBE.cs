using AvaliacaoSofia.DAO;
using AvaliacaoSofia.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSofia.BE
{
    class ProdutoBE
    {
        public Produto Produto { get; set; }
        private ProdutoDAO Dao { get; set; }

        public ProdutoBE()
        {
            Dao = new ProdutoDAO();
        }

        public void Create()
        {
            Dao.Prod = Produto;
            Dao.Create();
        }
        public void Delete()
        {
            Dao.Prod = Produto;
            Dao.Delete();
        }
        public void Update()
        {
            Dao.Prod = Produto;
            Dao.Update();
        }


        public List<Produto> List()
        {
            return Dao.List();
        }
    }
}
