using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVetAula0805
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cad = new cadastro();
            cad.Show();

        }

        private void veterinárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultar cons = new consultar();
            cons.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veterinárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            alterar alt = new alterar();
            alt.Show();
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluir exc = new excluir();
            exc.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
