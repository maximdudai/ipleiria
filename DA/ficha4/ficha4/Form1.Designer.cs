namespace ficha4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.balburdiaListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addValueButton = new System.Windows.Forms.Button();
            this.addNameButton = new System.Windows.Forms.Button();
            this.IterationNumbers = new System.Windows.Forms.NumericUpDown();
            this.randomNumberButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IterationNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomes:";
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(55, 103);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(276, 290);
            this.namesListBox.TabIndex = 1;
            // 
            // balburdiaListBox
            // 
            this.balburdiaListBox.FormattingEnabled = true;
            this.balburdiaListBox.Location = new System.Drawing.Point(564, 103);
            this.balburdiaListBox.Name = "balburdiaListBox";
            this.balburdiaListBox.Size = new System.Drawing.Size(478, 290);
            this.balburdiaListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balbundia:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(55, 399);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(276, 20);
            this.nameInput.TabIndex = 4;
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleAddName);
            // 
            // addValueButton
            // 
            this.addValueButton.Location = new System.Drawing.Point(564, 403);
            this.addValueButton.Name = "addValueButton";
            this.addValueButton.Size = new System.Drawing.Size(478, 23);
            this.addValueButton.TabIndex = 5;
            this.addValueButton.Text = "Dar Valores";
            this.addValueButton.UseVisualStyleBackColor = true;
            this.addValueButton.Click += new System.EventHandler(this.addValueButton_Click);
            // 
            // addNameButton
            // 
            this.addNameButton.Location = new System.Drawing.Point(55, 425);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(276, 23);
            this.addNameButton.TabIndex = 6;
            this.addNameButton.Text = "Adicionar";
            this.addNameButton.UseVisualStyleBackColor = true;
            this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // IterationNumbers
            // 
            this.IterationNumbers.Location = new System.Drawing.Point(361, 147);
            this.IterationNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IterationNumbers.Name = "IterationNumbers";
            this.IterationNumbers.Size = new System.Drawing.Size(169, 20);
            this.IterationNumbers.TabIndex = 7;
            this.IterationNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // randomNumberButton
            // 
            this.randomNumberButton.Location = new System.Drawing.Point(361, 173);
            this.randomNumberButton.Name = "randomNumberButton";
            this.randomNumberButton.Size = new System.Drawing.Size(169, 95);
            this.randomNumberButton.TabIndex = 8;
            this.randomNumberButton.Text = "Baralhar >>";
            this.randomNumberButton.UseVisualStyleBackColor = true;
            this.randomNumberButton.Click += new System.EventHandler(this.randomNumberButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero de Iteraçoes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.randomNumberButton);
            this.Controls.Add(this.IterationNumbers);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.addValueButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.balburdiaListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IterationNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.ListBox balburdiaListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addValueButton;
        private System.Windows.Forms.Button addNameButton;
        private System.Windows.Forms.NumericUpDown IterationNumbers;
        private System.Windows.Forms.Button randomNumberButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

