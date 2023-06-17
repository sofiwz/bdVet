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
    public partial class PessoaFisica : Form
    {
        private BE.PFBE pfBe { get; set; }
        private VO.Fisica pfVo { get; set; }
        public PessoaFisica()
        {
            InitializeComponent();
            Carregar();
            AtivarAlteracao(false);

        }

        private void BtVolt_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void AtivarAlteracao(bool ativar)
        {
            btInc.Enabled = !ativar;
            btAlt.Enabled = ativar;
            txtCod.Enabled = ativar;
        }
        private void GuardarValores()
        {

            pfVo = new VO.Fisica();
            pfVo.Id = Convert.ToInt32(txtCod.Text);
            pfVo.Nome = txtNm.Text;
            pfVo.CPF = txtNumDoc.Text;
            pfVo.Endereco = txtEnd.Text;

        }
        private void LimparTela()
        {
            txtCod.Text = "";
            txtNm.Text = "";
            txtNumDoc.Text = "";
            txtEnd.Text = "";
        }
        private void Carregar()
        {
            BE.PFBE be = new BE.PFBE();
            ListaPessoa.DataSource = null;
            ListaPessoa.DataSource = be.List();
            ListaPessoa.ValueMember = "id";
            ListaPessoa.DisplayMember = "nome";
            ListaPessoa.Refresh();
            
        }
        private void ReceberTela()
        {
            txtCod.Text = pfVo.Id.ToString();
            txtNm.Text = pfVo.Nome;
            txtNumDoc.Text = pfVo.CPF.ToString();
            txtEnd.Text = pfVo.Endereco;
        }

        private void BtEx_Click(object sender, EventArgs e)
        {
            pfBe = new BE.PFBE();
            pfBe.pessoa = (VO.Fisica)ListaPessoa.SelectedItem;
            pfBe.Delete();
            Carregar();
            LimparTela();
        }

        private void BtSel_Click(object sender, EventArgs e)
        {
            LimparTela();
            pfVo = (VO.Fisica)ListaPessoa.SelectedItem;
            ReceberTela();
            AtivarAlteracao(true);
        }

        private void BtInc_Click(object sender, EventArgs e)
        {
            GuardarValores();
            pfBe = new BE.PFBE();
            pfBe.pessoa = pfVo;
            pfBe.Create();
            Carregar();
            LimparTela();
            AtivarAlteracao(true);
        }

        private void BtAlt_Click(object sender, EventArgs e)
        {
            GuardarValores();
            pfBe = new BE.PFBE();
            pfBe.pessoa = pfVo;
            pfBe.Update();
            Carregar();
            LimparTela();
        }

        private void BtCan_Click(object sender, EventArgs e)
        {
            LimparTela();
            AtivarAlteracao(false);
        }
    }
}
