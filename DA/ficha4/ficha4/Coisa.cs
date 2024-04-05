using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha4
{


    internal class Coisa
    {
        public string Nome { get; set; }

        public DateTime Hora { get; }

        public int Pontos { get; set; }

        private List<int> TotalPontos;

        public Coisa(DateTime hora, string nome, int pontos)
        {
            Nome = nome;
            Hora = DateTime.Now;
            Pontos = 0;
            TotalPontos = new List<int>();
        }

        public void Pontuar(int pontos)
        {
            this.Pontos += pontos;
        }

        public void AdicionarPontos(int pontos)
        {
            TotalPontos.Add(pontos);
        }

        private string GetTotalPontos()
        {
            string pontosLista = "";

           foreach(var pontos in TotalPontos)
           {
                pontosLista += $"{pontos}-";

           }

           string getListPontos = "";
           if (pontosLista.Length > 0)
           {
                getListPontos = pontosLista.Remove(pontosLista.Length - 1);
           }

            return getListPontos;
        }

        public override string ToString()
        {
            if(this.Pontos == 0)
            {
                return $"{this.Hora} - {this.Nome}: (0) total: 0";
            }
            return $"{this.Hora} - {this.Nome}: ({this.GetTotalPontos()}) total: {this.Pontos}";
        }
    }
}