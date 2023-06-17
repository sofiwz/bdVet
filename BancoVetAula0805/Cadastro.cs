using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoVetAula0805
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCRV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCanc_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btSav_Click(object sender, EventArgs e)
        {
            string conectar = "server = localhost; pwd = ''; uid = root; database = clinica";
            MySqlConnection conexao = new MySqlConnection(conectar);
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("INSERT INTO veterinario(nome,crmv,formacao) VALUES(" +
                "'" + txtNome.Text + "','"
                + txtCRV.Text + "','"
                + comboForm.Text + "');", conexao);
            comando.ExecuteReader();
            MessageBox.Show("Cadastrado");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
