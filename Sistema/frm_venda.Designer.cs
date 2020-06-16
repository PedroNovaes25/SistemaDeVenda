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
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_cliente = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.txt_data_vencimento = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_pagamento = new System.Windows.Forms.ComboBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_novoItem = new System.Windows.Forms.Button();
            this.btn_fin_pedido = new System.Windows.Forms.Button();
            this.btn_fin_venda = new System.Windows.Forms.Button();
            this.CB_produto = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewItensVenda = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.txt_valorPago = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_novaVenda = new System.Windows.Forms.Button();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(81, 17);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(44, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Clientes";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(60, 68);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(77, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(397, 68);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(249, 68);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(90, 22);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(678, 101);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 5;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(678, 144);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 6;
            descontoLabel.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(678, 190);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(62, 13);
            valorPagoLabel.TabIndex = 8;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(87, 348);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(64, 13);
            codigoStatusLabel.TabIndex = 19;
            codigoStatusLabel.Text = "Pagamento:";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(59, 376);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataVencimentoLabel.TabIndex = 21;
            dataVencimentoLabel.Text = "Data Vencimento:";
            // 
            // CB_cliente
            // 
            this.CB_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_cliente.DataSource = this.pessoasBindingSource;
            this.CB_cliente.DisplayMember = "Nome";
            this.CB_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cliente.FormattingEnabled = true;
            this.CB_cliente.Location = new System.Drawing.Point(131, 14);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(dataVencimentoLabel);
            this.groupBox1.Controls.Add(this.txt_data_vencimento);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.CB_pagamento);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_novoItem);
            this.groupBox1.Controls.Add(this.btn_fin_pedido);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.btn_fin_venda);
            this.groupBox1.Controls.Add(this.CB_produto);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(this.dataGridViewItensVenda);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.txt_valorPago);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.txt_quantidade);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.txt_Desconto);
            this.groupBox1.Controls.Add(this.txt_Valor);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(157, 398);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(100, 23);
            this.btn_finalizar.TabIndex = 23;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click_1);
            // 
            // txt_data_vencimento
            // 
            this.txt_data_vencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataVencimento", true));
            this.txt_data_vencimento.Enabled = false;
            this.txt_data_vencimento.Location = new System.Drawing.Point(157, 372);
            this.txt_data_vencimento.Name = "txt_data_vencimento";
            this.txt_data_vencimento.Size = new System.Drawing.Size(100, 20);
            this.txt_data_vencimento.TabIndex = 22;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(sistema.DAL.ContasReceber);
            // 
            // CB_pagamento
            // 
            this.CB_pagamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "StatusPagamento", true));
            this.CB_pagamento.DataSource = this.statusPagamentoBindingSource;
            this.CB_pagamento.DisplayMember = "Status";
            this.CB_pagamento.Enabled = false;
            this.CB_pagamento.FormattingEnabled = true;
            this.CB_pagamento.Location = new System.Drawing.Point(157, 345);
            this.CB_pagamento.Name = "CB_pagamento";
            this.CB_pagamento.Size = new System.Drawing.Size(100, 21);
            this.CB_pagamento.TabIndex = 20;
            this.CB_pagamento.ValueMember = "Codigo";
            this.CB_pagamento.SelectedIndexChanged += new System.EventHandler(this.CB_pagamento_SelectedIndexChanged_1);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(681, 317);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(100, 23);
            this.btn_imprimir.TabIndex = 12;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_novoItem
            // 
            this.btn_novoItem.Location = new System.Drawing.Point(681, 53);
            this.btn_novoItem.Name = "btn_novoItem";
            this.btn_novoItem.Size = new System.Drawing.Size(75, 23);
            this.btn_novoItem.TabIndex = 6;
            this.btn_novoItem.Text = "Novo Item";
            this.btn_novoItem.UseVisualStyleBackColor = true;
            this.btn_novoItem.Click += new System.EventHandler(this.btn_novoItem_Click);
            // 
            // btn_fin_pedido
            // 
            this.btn_fin_pedido.Location = new System.Drawing.Point(681, 259);
            this.btn_fin_pedido.Name = "btn_fin_pedido";
            this.btn_fin_pedido.Size = new System.Drawing.Size(100, 23);
            this.btn_fin_pedido.TabIndex = 11;
            this.btn_fin_pedido.Text = "Finalizar Pedido";
            this.btn_fin_pedido.UseVisualStyleBackColor = true;
            this.btn_fin_pedido.Click += new System.EventHandler(this.btn_fin_pedido_Click);
            // 
            // btn_fin_venda
            // 
            this.btn_fin_venda.Location = new System.Drawing.Point(681, 288);
            this.btn_fin_venda.Name = "btn_fin_venda";
            this.btn_fin_venda.Size = new System.Drawing.Size(100, 23);
            this.btn_fin_venda.TabIndex = 10;
            this.btn_fin_venda.Text = "Finalizar Venda";
            this.btn_fin_venda.UseVisualStyleBackColor = true;
            this.btn_fin_venda.Click += new System.EventHandler(this.btn_fin_venda_Click);
            // 
            // CB_produto
            // 
            this.CB_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.CB_produto.DataSource = this.produtoBindingSource;
            this.CB_produto.DisplayMember = "Descricao";
            this.CB_produto.FormattingEnabled = true;
            this.CB_produto.Location = new System.Drawing.Point(143, 19);
            this.CB_produto.Name = "CB_produto";
            this.CB_produto.Size = new System.Drawing.Size(422, 21);
            this.CB_produto.TabIndex = 9;
            this.CB_produto.ValueMember = "Codigo";
            this.CB_produto.SelectedIndexChanged += new System.EventHandler(this.CB_produto_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(sistema.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistema.DAL.Produto);
            // 
            // dataGridViewItensVenda
            // 
            this.dataGridViewItensVenda.AllowUserToAddRows = false;
            this.dataGridViewItensVenda.AllowUserToDeleteRows = false;
            this.dataGridViewItensVenda.AutoGenerateColumns = false;
            this.dataGridViewItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.columnValorTotal});
            this.dataGridViewItensVenda.DataSource = this.itensVendaBindingSource;
            this.dataGridViewItensVenda.Location = new System.Drawing.Point(62, 101);
            this.dataGridViewItensVenda.Name = "dataGridViewItensVenda";
            this.dataGridViewItensVenda.ReadOnly = true;
            this.dataGridViewItensVenda.Size = new System.Drawing.Size(579, 239);
            this.dataGridViewItensVenda.TabIndex = 8;
            this.dataGridViewItensVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItensVenda_CellFormatting);
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "CodigoProduto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 135;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // columnValorTotal
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.columnValorTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnValorTotal.HeaderText = "Valor Total";
            this.columnValorTotal.Name = "columnValorTotal";
            this.columnValorTotal.ReadOnly = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(286, 65);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // txt_valorPago
            // 
            this.txt_valorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_valorPago.Location = new System.Drawing.Point(681, 206);
            this.txt_valorPago.Name = "txt_valorPago";
            this.txt_valorPago.ReadOnly = true;
            this.txt_valorPago.Size = new System.Drawing.Size(100, 20);
            this.txt_valorPago.TabIndex = 9;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.txt_quantidade.Location = new System.Drawing.Point(465, 65);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Codigo", true));
            this.txt_codigo.Location = new System.Drawing.Point(143, 65);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_Desconto.Location = new System.Drawing.Point(681, 160);
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.ReadOnly = true;
            this.txt_Desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_Desconto.TabIndex = 7;
            // 
            // txt_Valor
            // 
            this.txt_Valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_Valor.Location = new System.Drawing.Point(681, 117);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.ReadOnly = true;
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 6;
            // 
            // btn_novaVenda
            // 
            this.btn_novaVenda.Location = new System.Drawing.Point(477, 12);
            this.btn_novaVenda.Name = "btn_novaVenda";
            this.btn_novaVenda.Size = new System.Drawing.Size(75, 23);
            this.btn_novaVenda.TabIndex = 5;
            this.btn_novaVenda.Text = "Nova Venda";
            this.btn_novaVenda.UseVisualStyleBackColor = true;
            this.btn_novaVenda.Click += new System.EventHandler(this.btn_novaVenda_Click);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.btn_novaVenda);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewItensVenda;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.ComboBox CB_produto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btn_novaVenda;
        private System.Windows.Forms.Button btn_novoItem;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.TextBox txt_valorPago;
        private System.Windows.Forms.Button btn_fin_venda;
        private System.Windows.Forms.Button btn_fin_pedido;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorTotal;
        private System.Windows.Forms.ComboBox CB_pagamento;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker txt_data_vencimento;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
    }
}