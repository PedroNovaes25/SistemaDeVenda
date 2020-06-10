namespace Sistema
{
    partial class frm_venda
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
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            this.CB_cliente = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itensVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.codigoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(51, 23);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(44, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Clientes";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(42, 33);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(66, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo Item:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(325, 36);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(83, 13);
            codigoProdutoLabel.TabIndex = 2;
            codigoProdutoLabel.Text = "Codigo Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(343, 72);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(74, 68);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // CB_cliente
            // 
            this.CB_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_cliente.DataSource = this.pessoasBindingSource;
            this.CB_cliente.DisplayMember = "Nome";
            this.CB_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cliente.FormattingEnabled = true;
            this.CB_cliente.Location = new System.Drawing.Point(101, 20);
            this.CB_cliente.Name = "CB_cliente";
            this.CB_cliente.Size = new System.Drawing.Size(121, 21);
            this.CB_cliente.TabIndex = 2;
            this.CB_cliente.ValueMember = "Codigo";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(sistema.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itensVendaDataGridView);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.codigoProdutoTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 364);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            // 
            // itensVendaDataGridView
            // 
            this.itensVendaDataGridView.AllowUserToAddRows = false;
            this.itensVendaDataGridView.AllowUserToDeleteRows = false;
            this.itensVendaDataGridView.AutoGenerateColumns = false;
            this.itensVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.itensVendaDataGridView.DataSource = this.itensVendaBindingSource;
            this.itensVendaDataGridView.Location = new System.Drawing.Point(28, 105);
            this.itensVendaDataGridView.Name = "itensVendaDataGridView";
            this.itensVendaDataGridView.ReadOnly = true;
            this.itensVendaDataGridView.Size = new System.Drawing.Size(543, 239);
            this.itensVendaDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(sistema.DAL.ItensVenda);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(111, 65);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(411, 69);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // codigoProdutoTextBox
            // 
            this.codigoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "CodigoProduto", true));
            this.codigoProdutoTextBox.Location = new System.Drawing.Point(411, 33);
            this.codigoProdutoTextBox.Name = "codigoProdutoTextBox";
            this.codigoProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoProdutoTextBox.TabIndex = 3;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(111, 29);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.CB_cliente);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView itensVendaDataGridView;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox codigoProdutoTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}