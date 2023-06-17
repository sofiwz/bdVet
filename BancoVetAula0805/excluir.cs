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
    public partial class excluir : Form
    {
        private void ExibirDados()
        {
            try
            {
                string connect = "server = localhost; pwd = ''; uid = root; database = clinica";
                MySqlConnection conex = new MySqlConnection(connect);
                conex.Open();

                DataTable dt = new DataTable();
                MySqlDataAdapter adapt = new MySqlDataAdapter("Select * FROM veterinario", conex);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch
            {
                throw;
            }
        }
            public excluir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCrv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBscCad_Click(object sender, EventArgs e)
        {
            string conectar = "server = localhost; pwd = ''; uid = root; database = clinica";
            MySqlConnection conexao = new MySqlConnection(conectar);
            conexao.Open();

            string sql = "SELECT nome, formacao FROM veterinario WHERE crmv=?";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            panel1.Visible = true;
            cmd.Parameters.AddWithValue("@crmv", txtCrv.Text);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNome.Text = dr[0].ToString();
                txtForm.Text = dr[1].ToString();
            }

        }

        private void btExCad_Click(object sender, EventArgs e)
        {
            string conectar = "server = localhost; pwd = ''; uid = root; database = clinica";
            MySqlConnection conexao = new MySqlConnection(conectar);
            conexao.Open();

            string sql = "DELETE FROM veterinario WHERE crmv=@crmv;";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@crmv", txtCrv.Text);
            cmd.ExecuteNonQuery();

            txtCrv.Clear();
            txtForm.Clear();
            txtNome.Clear();

            ExibirDados();
        }

        private void btCanc_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
