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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaVendas tela = new ListaVendas();
            tela.Show();
        }

        private void btCad_Click(object sender, EventArgs e)
        {
            PessoaFisica tela = new PessoaFisica();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PessoaJuridica tela = new PessoaJuridica();
            tela.Show();
        }
    }
}
