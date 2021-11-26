using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidade
{
    internal class Item
    {
       
        
        private string texto { get; set; }
        private int id { get; set; }
        private double valor { get; set; }
        private DateTime data { get; set; }

        public void setTexto(string param)
        {
            this.texto = param;
        }

        public string getTexto()
        {
            return this.texto;
        }
        public void setId(int param)
        {
            this.id = param;
        }
        public int getId()
        {
            return this.id;
        }
        public void setValor(double param)
        {
            this.valor = param;
        }
        public double getValor()
        {
            return this.valor;
        }
        public void setData(DateTime param)
        {
            this.data = param;
        }
        public DateTime getData()
        {
            return this.data;
        }
        
    }
}
