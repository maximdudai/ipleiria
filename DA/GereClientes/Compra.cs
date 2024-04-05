using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class Compra
    {
        public DateTime Time { get; set; }
        public List<LinhaCompra> LinhasCompra { get; set; }
        public double Total { get; set; }

        public Compra()
        {
            this.Time = DateTime.Now;
            this.Total = 0.0;
            this.LinhasCompra = new List<LinhaCompra>();
        }

        public void AdicionarLinhaCompra(LinhaCompra linhaCompra)
        {
            LinhasCompra.Add(linhaCompra);
            this.Total += linhaCompra.valor;
        }

        public void RemoverLinhaCompra(int compra_id)
        {
            this.Total -= LinhasCompra[compra_id].valor;
            LinhasCompra.RemoveAt(compra_id);
        }

        public double GetTotal()
        {
            return this.Total;
        }

        public override string ToString()
        {
            string output = $"{this.Time}";
            if(this.Total > 0.0)
            {
                String.Join(output, $" - {this.Total}");
            }
            return output;
        }
    }
}
