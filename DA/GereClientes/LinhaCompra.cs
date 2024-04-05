using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class LinhaCompra
    {
        public string descricao { get; set; }
        public double valor { get; set; }


        public LinhaCompra(string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"{this.descricao} - {this.valor}";
        }
    }   
}
