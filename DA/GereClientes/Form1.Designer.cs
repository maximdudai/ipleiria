namespace GereClientes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InserirClientGroupBox = new System.Windows.Forms.GroupBox();
            this.addClient = new System.Windows.Forms.Button();
            this.clientNIFInput = new System.Windows.Forms.TextBox();
            this.clientNameInput = new System.Windows.Forms.TextBox();
            this.clientNIFlabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groubox4 = new System.Windows.Forms.GroupBox();
            this.linhaComprasTotal = new System.Windows.Forms.Label();
            this.apagarLinhaDeCompra = new System.Windows.Forms.Button();
            this.apagarCompra = new System.Windows.Forms.Button();
            this.criarCompra = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.adicionarLinhaDeCompra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.valorLinhaDeCompraInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descricaoLinhaDeCompraInput = new System.Windows.Forms.TextBox();
            this.linhaDeCompras = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comprasListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.restaurantNIF = new System.Windows.Forms.Label();
            this.restaurantName = new System.Windows.Forms.Label();
            this.restaurantUItotal = new System.Windows.Forms.Label();
            this.InserirClientGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groubox4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // InserirClientGroupBox
            // 
            this.InserirClientGroupBox.Controls.Add(this.addClient);
            this.InserirClientGroupBox.Controls.Add(this.clientNIFInput);
            this.InserirClientGroupBox.Controls.Add(this.clientNameInput);
            this.InserirClientGroupBox.Controls.Add(this.clientNIFlabel);
            this.InserirClientGroupBox.Controls.Add(this.clientNameLabel);
            this.InserirClientGroupBox.Controls.Add(this.label1);
            this.InserirClientGroupBox.Location = new System.Drawing.Point(32, 29);
            this.InserirClientGroupBox.Name = "InserirClientGroupBox";
            this.InserirClientGroupBox.Size = new System.Drawing.Size(297, 139);
            this.InserirClientGroupBox.TabIndex = 1;
            this.InserirClientGroupBox.TabStop = false;
            this.InserirClientGroupBox.Text = "Inserir Cliente";
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(196, 110);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(95, 23);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "adicionar";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientNIFInput
            // 
            this.clientNIFInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNIFInput.Location = new System.Drawing.Point(79, 81);
            this.clientNIFInput.Name = "clientNIFInput";
            this.clientNIFInput.Size = new System.Drawing.Size(212, 20);
            this.clientNIFInput.TabIndex = 4;
            // 
            // clientNameInput
            // 
            this.clientNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNameInput.Location = new System.Drawing.Point(79, 35);
            this.clientNameInput.Name = "clientNameInput";
            this.clientNameInput.Size = new System.Drawing.Size(212, 20);
            this.clientNameInput.TabIndex = 2;
            // 
            // clientNIFlabel
            // 
            this.clientNIFlabel.AutoSize = true;
            this.clientNIFlabel.Location = new System.Drawing.Point(6, 85);
            this.clientNIFlabel.Name = "clientNIFlabel";
            this.clientNIFlabel.Size = new System.Drawing.Size(24, 13);
            this.clientNIFlabel.TabIndex = 3;
            this.clientNIFlabel.Text = "NIF";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(6, 39);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.clientNameLabel.TabIndex = 2;
            this.clientNameLabel.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaClientes);
            this.groupBox2.Location = new System.Drawing.Point(32, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 398);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(9, 19);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(282, 368);
            this.listaClientes.TabIndex = 0;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.onClientChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.restaurantUItotal);
            this.groupBox3.Controls.Add(this.groubox4);
            this.groupBox3.Controls.Add(this.restaurantNIF);
            this.groupBox3.Controls.Add(this.restaurantName);
            this.groupBox3.Location = new System.Drawing.Point(355, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 558);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // groubox4
            // 
            this.groubox4.Controls.Add(this.linhaComprasTotal);
            this.groubox4.Controls.Add(this.apagarLinhaDeCompra);
            this.groubox4.Controls.Add(this.apagarCompra);
            this.groubox4.Controls.Add(this.criarCompra);
            this.groubox4.Controls.Add(this.groupBox4);
            this.groubox4.Controls.Add(this.linhaDeCompras);
            this.groubox4.Controls.Add(this.label4);
            this.groubox4.Controls.Add(this.comprasListBox);
            this.groubox4.Controls.Add(this.label3);
            this.groubox4.Location = new System.Drawing.Point(7, 160);
            this.groubox4.Name = "groubox4";
            this.groubox4.Size = new System.Drawing.Size(773, 392);
            this.groubox4.TabIndex = 4;
            this.groubox4.TabStop = false;
            this.groubox4.Text = "Compras";
            // 
            // linhaComprasTotal
            // 
            this.linhaComprasTotal.AutoSize = true;
            this.linhaComprasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.linhaComprasTotal.Location = new System.Drawing.Point(268, 324);
            this.linhaComprasTotal.Name = "linhaComprasTotal";
            this.linhaComprasTotal.Size = new System.Drawing.Size(54, 13);
            this.linhaComprasTotal.TabIndex = 5;
            this.linhaComprasTotal.Text = "total: 0.00";
            // 
            // apagarLinhaDeCompra
            // 
            this.apagarLinhaDeCompra.Location = new System.Drawing.Point(380, 319);
            this.apagarLinhaDeCompra.Name = "apagarLinhaDeCompra";
            this.apagarLinhaDeCompra.Size = new System.Drawing.Size(87, 23);
            this.apagarLinhaDeCompra.TabIndex = 10;
            this.apagarLinhaDeCompra.Text = "Apagar";
            this.apagarLinhaDeCompra.UseVisualStyleBackColor = true;
            this.apagarLinhaDeCompra.Click += new System.EventHandler(this.apagarLinhaDeCompra_Click);
            // 
            // apagarCompra
            // 
            this.apagarCompra.Location = new System.Drawing.Point(138, 319);
            this.apagarCompra.Name = "apagarCompra";
            this.apagarCompra.Size = new System.Drawing.Size(87, 23);
            this.apagarCompra.TabIndex = 9;
            this.apagarCompra.Text = "Apagar";
            this.apagarCompra.UseVisualStyleBackColor = true;
            this.apagarCompra.Click += new System.EventHandler(this.apagarCompra_Click);
            // 
            // criarCompra
            // 
            this.criarCompra.Location = new System.Drawing.Point(27, 319);
            this.criarCompra.Name = "criarCompra";
            this.criarCompra.Size = new System.Drawing.Size(89, 23);
            this.criarCompra.TabIndex = 6;
            this.criarCompra.Text = "Criar Compra";
            this.criarCompra.UseVisualStyleBackColor = true;
            this.criarCompra.Click += new System.EventHandler(this.criarCompra_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.adicionarLinhaDeCompra);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.valorLinhaDeCompraInput);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.descricaoLinhaDeCompraInput);
            this.groupBox4.Location = new System.Drawing.Point(511, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 251);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adicionar Linha de Compra";
            // 
            // adicionarLinhaDeCompra
            // 
            this.adicionarLinhaDeCompra.Location = new System.Drawing.Point(50, 185);
            this.adicionarLinhaDeCompra.Name = "adicionarLinhaDeCompra";
            this.adicionarLinhaDeCompra.Size = new System.Drawing.Size(105, 23);
            this.adicionarLinhaDeCompra.TabIndex = 4;
            this.adicionarLinhaDeCompra.Text = "Adicionar Linha";
            this.adicionarLinhaDeCompra.UseVisualStyleBackColor = true;
            this.adicionarLinhaDeCompra.Click += new System.EventHandler(this.adicionarLinhaDeCompra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Valor:";
            // 
            // valorLinhaDeCompraInput
            // 
            this.valorLinhaDeCompraInput.Location = new System.Drawing.Point(18, 125);
            this.valorLinhaDeCompraInput.Name = "valorLinhaDeCompraInput";
            this.valorLinhaDeCompraInput.Size = new System.Drawing.Size(164, 20);
            this.valorLinhaDeCompraInput.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descricao:";
            // 
            // descricaoLinhaDeCompraInput
            // 
            this.descricaoLinhaDeCompraInput.Location = new System.Drawing.Point(17, 62);
            this.descricaoLinhaDeCompraInput.Name = "descricaoLinhaDeCompraInput";
            this.descricaoLinhaDeCompraInput.Size = new System.Drawing.Size(164, 20);
            this.descricaoLinhaDeCompraInput.TabIndex = 0;
            // 
            // linhaDeCompras
            // 
            this.linhaDeCompras.FormattingEnabled = true;
            this.linhaDeCompras.Location = new System.Drawing.Point(271, 62);
            this.linhaDeCompras.Name = "linhaDeCompras";
            this.linhaDeCompras.Size = new System.Drawing.Size(198, 251);
            this.linhaDeCompras.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(268, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Linha de Compras:";
            // 
            // comprasListBox
            // 
            this.comprasListBox.FormattingEnabled = true;
            this.comprasListBox.Location = new System.Drawing.Point(27, 62);
            this.comprasListBox.Name = "comprasListBox";
            this.comprasListBox.Size = new System.Drawing.Size(198, 251);
            this.comprasListBox.TabIndex = 1;
            this.comprasListBox.SelectedIndexChanged += new System.EventHandler(this.OnCompraChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compras:";
            // 
            // restaurantNIF
            // 
            this.restaurantNIF.AutoSize = true;
            this.restaurantNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.restaurantNIF.Location = new System.Drawing.Point(55, 72);
            this.restaurantNIF.Name = "restaurantNIF";
            this.restaurantNIF.Size = new System.Drawing.Size(80, 18);
            this.restaurantNIF.TabIndex = 1;
            this.restaurantNIF.Text = "000000000";
            // 
            // restaurantName
            // 
            this.restaurantName.AutoSize = true;
            this.restaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantName.Location = new System.Drawing.Point(53, 47);
            this.restaurantName.Name = "restaurantName";
            this.restaurantName.Size = new System.Drawing.Size(179, 25);
            this.restaurantName.TabIndex = 0;
            this.restaurantName.Text = "Restaurant Name";
            // 
            // restaurantUItotal
            // 
            this.restaurantUItotal.AutoSize = true;
            this.restaurantUItotal.Location = new System.Drawing.Point(439, 72);
            this.restaurantUItotal.Name = "restaurantUItotal";
            this.restaurantUItotal.Size = new System.Drawing.Size(43, 13);
            this.restaurantUItotal.TabIndex = 5;
            this.restaurantUItotal.Text = "Total: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InserirClientGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InserirClientGroupBox.ResumeLayout(false);
            this.InserirClientGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groubox4.ResumeLayout(false);
            this.groubox4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InserirClientGroupBox;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox clientNIFInput;
        private System.Windows.Forms.TextBox clientNameInput;
        private System.Windows.Forms.Label clientNIFlabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label restaurantNIF;
        private System.Windows.Forms.Label restaurantName;
        private System.Windows.Forms.GroupBox groubox4;
        private System.Windows.Forms.ListBox linhaDeCompras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox comprasListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button apagarCompra;
        private System.Windows.Forms.Button criarCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label linhaComprasTotal;
        private System.Windows.Forms.Button apagarLinhaDeCompra;
        private System.Windows.Forms.Button adicionarLinhaDeCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valorLinhaDeCompraInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descricaoLinhaDeCompraInput;
        private System.Windows.Forms.Label restaurantUItotal;
    }
}

