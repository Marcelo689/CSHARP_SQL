using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidade;
using System.Configuration;

namespace WindowsFormsApp1.BaseDeDados
{
    internal class BD
    {
        public static List<Item> RetornaLista()
        {
            List<Item> itemL= new List<Item>();
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(con);
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * from item";

            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                item.setTexto(reader["texto"].ToString());
                item.setId(int.Parse(reader["id"].ToString()));
                item.setData(DateTime.Parse(reader["data"].ToString()));
                item.setValor(Double.Parse(reader["valor"].ToString()));
                itemL.Add(item);
            }
            conexao.Close();
            return itemL;
        }
        public static void InsereItem(Item item)
        {
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(con);
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();

            string texto = item.getTexto();
            double valor = item.getValor();
            DateTime data = item.getData();
            comando.CommandText = "Insert into item(texto,valor,data) values('"+texto+"',"+valor+",'"+data+"')";

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public static List<Item> ListaFiltrada(string filtro)
        {
            List<Item> itemL = new List<Item>();
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

            MySqlConnection conexao = new MySqlConnection(con);
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * from item where texto like '%"+filtro+"%'";

            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                item.setTexto(reader["texto"].ToString());
                item.setId(int.Parse(reader["id"].ToString()));
                item.setData(DateTime.Parse(reader["data"].ToString()));
                item.setValor(Double.Parse(reader["valor"].ToString()));
                itemL.Add(item);
            }
            conexao.Close();
            return itemL;
        }
    }
    
}
