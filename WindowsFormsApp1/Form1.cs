using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BaseDeDados;
using WindowsFormsApp1.Entidade;

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
            ListViewItem.Items.Clear();
            
            ListViewItem.View = View.Details;
            string filtro = TextBoxFiltro.Text;

            if (!string.IsNullOrEmpty(filtro))
            {
                List<Item> listaFiltrada = BD.ListaFiltrada(filtro);

                foreach(Item unidade in listaFiltrada )
                {
                    ListViewItem listView = new ListViewItem();

                    listView.SubItems[0].Text = unidade.getTexto();
                    listView.SubItems.Add(unidade.getValor().ToString("F2",CultureInfo.InvariantCulture));
                    listView.SubItems.Add(unidade.getData().ToString());
                    ListViewItem.Items.Add(listView);
                }
                
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            List<Item> lista = BD.RetornaLista();
            ListViewItem.View = View.Details;
            foreach (Item unidade in lista)
            {
                ListViewItem listView = new ListViewItem();
                listView.SubItems[0].Text = unidade.getTexto();
                listView.SubItems.Add(unidade.getValor().ToString("F2", CultureInfo.InvariantCulture));
                listView.SubItems.Add(unidade.getData().ToString());
                ListViewItem.Items.Add(listView);
            }
        }
    }
}
