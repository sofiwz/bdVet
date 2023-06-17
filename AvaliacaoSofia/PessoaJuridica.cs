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
    public partial class PessoaJuridica : Form
    {
        private BE.PJBE pjBE { get; set; }
        private VO.Juridica pjVO { get; set; }
        public PessoaJuridica()
        {
            InitializeComponent();
            CarregarLista();
            AtivarAlteracao(false);
        }
        
        private void AtivarAlteracao(bool ativar)
        {
            btInc.Enabled = !ativar;
            btAlt.Enabled = ativar;
            txtCod.Enabled = ativar;
        }
        private void GuardarValores()
        {

            pjVO = new VO.Juridica();
            pjVO.Nome = txtNm.Text;
            pjVO.CNPJ = txtNumDoc.Text;
            pjVO.Endereco = txtEnd.Text;

        }
        private void LimparTela()
        {
            txtCod.Text = "";
            txtNm.Text = "";
            txtNumDoc.Text = "";
            txtEnd.Text = "";
        }
        private void CarregarLista()
        {
            BE.PJBE be = new BE.PJBE();
            ListaPessoa.DataSource = null;
            ListaPessoa.DataSource = be.List();
            ListaPessoa.ValueMember = "id";
            ListaPessoa.DisplayMember = "nome";
            ListaPessoa.Refresh();

        }
        private void ReceberTela()
        {
            txtCod.Text = pjVO.Id.ToString();
            txtNm.Text = pjVO.Nome;
            txtNumDoc.Text = pjVO.CNPJ.ToString();
            txtEnd.Text = pjVO.Endereco;
        }
        private void BtVolt_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtEx_Click(object sender, EventArgs e)
        {
            pjBE = new BE.PJBE();
            pjBE.Pessoa = (VO.Juridica)ListaPessoa.SelectedItem;
            pjBE.Delete();
            CarregarLista();
            LimparTela();
        }

        private void BtSel_Click(object sender, EventArgs e)
        {
            LimparTela();
            pjVO = (VO.Juridica)ListaPessoa.SelectedItem;
            ReceberTela();
            AtivarAlteracao(true);
        }

        private void BtInc_Click(object sender, EventArgs e)
        {
            GuardarValores();
            pjBE = new BE.PJBE();
            pjBE.Pessoa = pjVO;
            pjBE.Create();
            CarregarLista();
            LimparTela();
            AtivarAlteracao(true);
        }

        private void BtAlt_Click(object sender, EventArgs e)
        {
            GuardarValores();
            pjBE = new BE.PJBE();
            pjBE.Pessoa = pjVO;
            pjBE.Update();
            CarregarLista();
            LimparTela();
        }

        private void BtCan_Click(object sender, EventArgs e)
        {
            LimparTela();
            AtivarAlteracao(false);
        }
    }
}
