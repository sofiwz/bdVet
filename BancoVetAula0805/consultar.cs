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
    public partial class consultar : Form
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

        public consultar()
        {
            InitializeComponent();
        }

        private void txtConsCrv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBusc_Click(object sender, EventArgs e)
        {
            
            string conectar = "server = localhost; pwd = ''; uid = root; database = clinica";
            MySqlConnection conexao = new MySqlConnection(conectar);
            conexao.Open();

            string sql = "SELECT nome, formacao FROM veterinario WHERE crmv=?";
            MySqlCommand cmd = new MySqlCommand (sql, conexao);
            panel1.Visible = true;
            cmd.Parameters.AddWithValue("@crmv", txtConsCrv.Text);
            MySqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                txtConsNome.Text = dr[0].ToString();
                txtConsForm.Text = dr[1].ToString();
            }

            ExibirDados();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
