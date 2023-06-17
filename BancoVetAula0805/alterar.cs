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
    public partial class alterar : Form
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
        public alterar()
        {
            InitializeComponent();
        }

        private void btCanc_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void btAltCad_Click(object sender, EventArgs e)
        {
            string conectar = "server = localhost; pwd = ''; uid = root; database = clinica";
            MySqlConnection conexao = new MySqlConnection(conectar);
            conexao.Open();

            string sql = "UPDATE veterinario SET nome=@nome, formacao=@formacao WHERE crmv=@crmv";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@crmv", txtCrv.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@formacao", txtForm.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro Alterado");

            txtCrv.Clear();
            txtForm.Clear();
            txtNome.Clear();

            ExibirDados();

        }
    }
}
