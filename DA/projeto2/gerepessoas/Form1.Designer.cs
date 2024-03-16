namespace gerepessoas
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
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.addressLabel = new System.Windows.Forms.Label();
            this.moradaInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nomeInput
            // 
            this.nomeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeInput.Location = new System.Drawing.Point(48, 57);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.Size = new System.Drawing.Size(227, 20);
            this.nomeInput.TabIndex = 0;
            this.nomeInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(45, 41);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(48, 110);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(45, 305);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(43, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Morada";
            // 
            // moradaInput
            // 
            this.moradaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moradaInput.Location = new System.Drawing.Point(48, 321);
            this.moradaInput.Name = "moradaInput";
            this.moradaInput.Size = new System.Drawing.Size(227, 20);
            this.moradaInput.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(200, 380);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Adicionar >>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(541, 380);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 23);
            this.buttonPoint.TabIndex = 7;
            this.buttonPoint.Text = "Pontuar";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(395, 57);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(368, 290);
            this.listBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.moradaInput);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeInput;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox moradaInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.ListBox listBox;
    }
}

