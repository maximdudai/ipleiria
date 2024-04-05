using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereClientes
{
    public partial class Form1 : Form
    {
        private List<Client> clientList;
        private Client selectedClient;

        private List<Compra> compraList;
        private Compra selectedCompra;

        public Form1()
        {
            InitializeComponent();

            this.clientList = new List<Client>();
            this.selectedClient = null;

            this.compraList = new List<Compra>();
            this.selectedCompra = null;
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            if (clientNIFInput.Text.Length != 9)
            {
                MessageBox.Show("NIF must be a number with 9 chars");
                return;
            }

            Client client = new Client(clientNameInput.Text, clientNIFInput.Text);
            clientList.Add(client);

            listaClientes.DataSource = null;
            listaClientes.DataSource = clientList;
        }

        private void criarCompra_Click(object sender, EventArgs e)
        {
            Client client = selectedClient;
            Compra compra = new Compra();

            selectedClient.AdicionarCompra(compra);

            changeListOfProducts(comprasListBox, client.ListaCompras);
        }
        private void OnCompraChanged(object sender, EventArgs e)
        {
            if (comprasListBox.SelectedIndex == -1)
            {
                return;
            }

            selectedCompra = (Compra)comprasListBox.SelectedItem;

            changeListOfProducts(linhaDeCompras, selectedCompra.LinhasCompra);
        }
        private void onClientChanged(object sender, EventArgs e)
        {
            
            Client client = (Client)listaClientes.SelectedItem;
            
            if(client == null)
            {
                return;
            }

            restaurantName.Text = client.Name;
            restaurantNIF.Text = client.Nif;

            selectedClient = client;

            changeListOfProducts(comprasListBox, client.ListaCompras); // update list of purchases
            changeListOfProducts(linhaDeCompras, new List<object>());

            updateTotal();
        }
        private void adicionarLinhaDeCompra_Click(object sender, EventArgs e)
        {
            bool isValidValue = double.TryParse(valorLinhaDeCompraInput.Text, out double valor) && (valor > 0);

            if(!isValidValue)
            {
                MessageBox.Show("Value must be a positive number");
                return;
            }

            selectedCompra.AdicionarLinhaCompra(new LinhaCompra(descricaoLinhaDeCompraInput.Text, valor));

            linhaDeCompras.DataSource = null;
            linhaDeCompras.DataSource = selectedCompra.LinhasCompra;

            changeListOfProducts(linhaDeCompras, selectedCompra.LinhasCompra);
        }
        // ----------------- GLOBAL -----------------
        public void changeListOfProducts<T>(ListBox listBox, List<T> items)
        {
            listBox.DataSource = null;
            listBox.DataSource = items;

            updateTotal();
        }

        private void updateTotal()
        {
            if(selectedClient == null || selectedCompra == null)
            {
                return;
            }
            linhaComprasTotal.Text = $"Total: {selectedCompra.GetTotal()}";
         
            var totalByClient = clientList[clientList.IndexOf(selectedClient)].ListaCompras.Sum(x => x.Total);
            restaurantUItotal.Text = $"{totalByClient}";
        }

        private void apagarCompra_Click(object sender, EventArgs e)
        {
            int index = comprasListBox.SelectedIndex;
            if(index == -1)
            {
                return;
            }

            Compra compra = selectedClient.ListaCompras[index];
            selectedClient.RemoverCompra(compra);

            selectedCompra = null;

            changeListOfProducts(comprasListBox, selectedClient.ListaCompras);
            changeListOfProducts(linhaDeCompras, new List<object>());
        }

        private void apagarLinhaDeCompra_Click(object sender, EventArgs e)
        {
            int index = linhaDeCompras.SelectedIndex;

            if(index == -1)
            {
                return;
            }

            selectedCompra.RemoverLinhaCompra(index);

            linhaDeCompras.DataSource = null;
            linhaDeCompras.DataSource = selectedCompra.LinhasCompra;

            updateTotal();
        }
    }
}
