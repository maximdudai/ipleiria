using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerepessoas
{
    public partial class Form1 : Form
    {
        private List<Pessoa> Pessoas;
        public Form1()
        {

            InitializeComponent();

            Pessoas = new List<Pessoa>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 1 - Obter os valores dos campos
            string nome = nomeInput.Text;
            string morada = moradaInput.Text;
            DateTime dataNascimento = monthCalendar.SelectionStart;

            // 2 - Criar um objeto pessoa
            Pessoa pessoa = new Pessoa(nome, morada, dataNascimento);

            // 3 - Adicionar a pessoa à lista
            //listBox.Items.Add(pessoa);
            Pessoas.Add(pessoa);

            // 4 - Atualizar a lista
            updatePessoasListBox();
        }

        private void updatePessoasListBox()
        {
            listBox.DataSource = null;    
            listBox.DataSource = Pessoas;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (Pessoa pessoa in Pessoas)
            {
                int RandomPoint = rnd.Next(1, 11); 

                pessoa.Pontuar(RandomPoint);

            }
            updatePessoasListBox();
        }
    }
}
