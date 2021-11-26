using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Conectar
{
    internal class Conexao
    {
        public static MySqlConnection getConexao()
        {
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(con);
            return conexao;
        }
    }
}
