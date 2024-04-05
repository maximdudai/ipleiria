using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ficha4
{
    public partial class Form1 : Form
    {
        private List<String> Lista;
        private List<Coisa> Coisas;
        public Form1()
        {
            InitializeComponent();

            Lista = new List<String>();
            Coisas = new List<Coisa>();
        }


        private void randomNumberButton_Click(object sender, EventArgs e)
        {
            int IterationNumbers = (int)this.IterationNumbers.Value;

             if(Lista.Count <= 1)
            {
                MessageBox.Show("Lista de nomes tem de ter pelo menos 2 nomes", "Warning", MessageBoxButtons.OK);
                return;
            }

            for(var i = 0; i < IterationNumbers; i++)
            {

                var random = new Random();
                var index = random.Next(Lista.Count);

                DateTime Hora = DateTime.Now;
                //int miliseconds = Hora.Millisecond;

                // 2 - Criar uma pessoa
                Coisa coisa = new Coisa(Hora, Lista[index], 0);

                // 3 - Adicionar a pessoa à lista
                Coisas.Add(coisa);

                // 4 - Atualizar a lista
                updatePessoasListBox();
            }
        }

        private void addValueButton_Click(object sender, EventArgs e)
        {
            var random = new Random();

            foreach (var coisa in Coisas)
            {
                int RandomPoint = random.Next(1, 11);

                coisa.Pontuar(RandomPoint);
                coisa.AdicionarPontos(RandomPoint);

                updatePessoasListBox();
            }   

        }
        private void addNameButton_Click(object sender, EventArgs e)
        {
            if(nameInput.Text == "")
            {
                MessageBox.Show("Nome não pode ser vazio", "Error", MessageBoxButtons.OK);
                return;
            }
            string name = nameInput.Text;

            Lista.Add(name);

            updateListaString();

            //5 - Reset input
            nameInput.Text = "";
        }
        private void updateListaString()
        {
            namesListBox.DataSource = null;
            namesListBox.DataSource = Lista;
        }

        private void updatePessoasListBox()
        {
            balburdiaListBox.DataSource = null;
            balburdiaListBox.DataSource = Coisas;
        }

        private void handleAddName(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addNameButton_Click(sender, e);
            }
        }
    }
}
