using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerepessoas
{
    internal class Pessoa
    {
        public string Nome { get; }

        public string Morada { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int Pontos { get; set; }

        public Pessoa(string nome, string morada, DateTime dataNascimento)
        {
            Nome = nome;
            Morada = morada;
            DataNascimento = dataNascimento;

            Pontos = 0;
        }

        public int Idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }

        public void Pontuar(int pontos)
        {
            this.Pontos += pontos;
        }
        public int getPoints()
        {
            return this.Pontos;
        }

        public override string ToString()
        {
            return $"{this.Nome} (idade: {this.Idade()}): {this.Pontos} pts";
        }
    }
}
