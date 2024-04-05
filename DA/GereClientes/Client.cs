using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class Client
    {
        public string Name { get; }
        public string Nif { get; }
        public double Total { get; set; }

        public List<Compra> ListaCompras { get; set; }

        public Client(string name, string nif)
        {
            this.Name = name;
            this.Nif = nif;

            this.Total = 0.0;
            ListaCompras = new List<Compra>();
        }


        public void AdicionarCompra(Compra compra)
        {
            ListaCompras.Add(compra);
            this.Total += 0;

        }

        public void RemoverCompra(Compra compra)
        {
            bool removed = ListaCompras.Remove(compra);
            if (removed)
            {
                this.Total -= 0;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Nif}";
        }
    }
}
