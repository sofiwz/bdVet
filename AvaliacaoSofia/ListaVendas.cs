using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AvaliacaoSofia
{
    public partial class ListaVendas : Form
    {
        private BE.VendaBE prodBe { get; set; }
        private VO.Venda venda { get; set; }

        public ListaVendas()
        {
            InitializeComponent();
            Carregar();
            AtivarAlteracao(false);
        }
        private void AtivarAlteracao(bool ativar)
        {
            btInc.Enabled = !ativar;
            btAlt.Enabled = ativar;
            txtCod.Enabled = ativar;
        }
        private void CarregarTela()
        {
            venda = new VO.Venda();
           
            venda.Cliente = comboCli.Text;
            venda.Nome = comboProd.Text;
            venda.Qtd = int.Parse(txtQtd.Text);
        }
        private void LimparTela()
        {
            txtCod.Text = "";
            comboCli.Text = "";
            comboProd.Text = "";
            txtQtd.Text = "";
        }

        private void CarregarLista()
        {
            BE.VendaBE be = new BE.VendaBE();
            ListaVenda.DataSource = null;
            ListaVenda.DataSource = be.List();
            ListaVenda.ValueMember = "cod";
            ListaVenda.DisplayMember = "nome";
            ListaVenda.Refresh();
        }

        private void CarregarClienteCombo()
        {
            BE.PFBE pf = new BE.PFBE();
            BE.PJBE pj = new BE.PJBE();
            comboCli.DataSource = null;
            var listapj = pj.List();
            var listapf = pf.List();
            var novaLista = new List<VO.Pessoa>(listapj.Count + listapf.Count);
            novaLista.AddRange(listapj);
            novaLista.AddRange(listapf);
            comboCli.DataSource = novaLista;
            comboCli.ValueMember = "id";
            comboCli.DisplayMember = "nome";
            comboCli.Refresh();
        }

        private void CarregarProdutoCombo()
        {
            BE.ProdutoBE prod = new BE.ProdutoBE();
            comboProd.DataSource = prod.List();
            comboProd.ValueMember = "id";
            comboProd.DisplayMember = "nome";
            comboProd.Refresh();
        }

        private void Carregar()
        {
            CarregarLista();

            CarregarClienteCombo();

            CarregarProdutoCombo();
        }
        private void ReceberTela()
        {
            txtCod.Text = venda.Cod.ToString();
            comboCli.Text = venda.Cliente;
            comboProd.Text = venda.Nome;
            txtQtd.Text = venda.Qtd.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtVolt_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtInc_Click(object sender, EventArgs e)
        {
            CarregarTela();
            prodBe = new BE.VendaBE();
            prodBe.Venda = venda;
            prodBe.Create();
            Carregar();
            LimparTela();
            AtivarAlteracao(true);
        }

        private void BtSel_Click(object sender, EventArgs e)
        {
            LimparTela();
            venda = (VO.Venda)ListaVenda.SelectedItem;
            ReceberTela();
            AtivarAlteracao(true);
        }

        private void BtCan_Click(object sender, EventArgs e)
        {
            LimparTela();
            AtivarAlteracao(false);
        }

        private void BtAlt_Click(object sender, EventArgs e)
        {
            CarregarTela();
            prodBe = new BE.VendaBE();
            prodBe.Venda = venda;
            prodBe.Update();
            Carregar();
            LimparTela();
        }

        private void BtEx_Click(object sender, EventArgs e)
        {
            prodBe = new BE.VendaBE();
            prodBe.Venda = (VO.Venda)ListaVenda.SelectedItem;
            prodBe.Delete();
            Carregar();
            LimparTela();
        }
    }
}
