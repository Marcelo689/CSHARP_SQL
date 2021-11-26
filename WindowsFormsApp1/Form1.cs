using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(con);
            
            try
            {
                conexao.Open();
                MessageBox.Show("Se conectoou com sucesso ao banco de dados", "Alerta");
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "Select * from usuario where id = 1";
                var reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    MessageBox.Show(reader["nome"].ToString());
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao conectar " + erro.Message,"Alerta");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
