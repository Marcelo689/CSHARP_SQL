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
    public partial class TelaInserir : Form
    {
        public TelaInserir()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.setTexto(texto.Text);
            item.setValor(Double.Parse(Double.Parse(texto.Text).ToString("F2",CultureInfo.InvariantCulture)));
            item.setData(DateTime.Parse(data.Text));
            BD.InsereItem(item);

            this.Close();
        }
    }
}
