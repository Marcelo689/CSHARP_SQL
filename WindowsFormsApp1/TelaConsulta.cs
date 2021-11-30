using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BaseDeDados;
using WindowsFormsApp1.Entidade;

namespace Dividas
{
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void TelaConsulta_Load(object sender, EventArgs e)
        {
            List<Item> lista = BD.RetornaLista();
            listViewDeItems.View = View.Details;
            foreach (Item unidade in lista)
            {
                ListViewItem listView = new ListViewItem();
                listView.SubItems[0].Text = unidade.getTexto();
                listView.SubItems.Add(unidade.getValor().ToString("F2", CultureInfo.InvariantCulture));
                listView.SubItems.Add(unidade.getData().ToString());
                listViewDeItems.Items.Add(listView);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            listViewDeItems.Items.Clear();

            listViewDeItems.View = View.Details;
            string filtro = textBoxFiltro.Text;

            if (!string.IsNullOrEmpty(filtro))
            {
                List<Item> listaFiltrada = BD.ListaFiltrada(filtro);

                foreach (Item unidade in listaFiltrada)
                {
                    ListViewItem listView = new ListViewItem();

                    listView.SubItems[0].Text = unidade.getTexto();
                    listView.SubItems.Add(unidade.getValor().ToString("F2", CultureInfo.InvariantCulture));
                    listView.SubItems.Add(unidade.getData().ToString());
                    listViewDeItems.Items.Add(listView);
                }

            }
        }
    }
}
