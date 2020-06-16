using sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.Size = new Size(838, 88);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;

            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }
        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }
        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void btn_novaVenda_Click(object sender, EventArgs e)
        {
            this.Size = new Size(838, 527);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novaVenda.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda;
            NovoItem();
            CB_cliente.Enabled = false;
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.Codigo;
            this.ItemCorrente.Quantidade = 1;
            MostraSomaValores();
        }
        private void btn_novoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            dataGridViewItensVenda.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            NovoItem();

        }
        private void dataGridViewItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((Produto)e.Value).Descricao;
            }
        }
        private void CB_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_produto.SelectedItem != null)
            {
                var pro = (Produto)CB_produto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }
        private void MostraSomaValores()
        {
            decimal totalVenda = 0;

            foreach (DataGridViewRow item in dataGridViewItensVenda.Rows)
            {
                decimal valor = Convert.ToDecimal(item.Cells[3].Value);
                int quantidade = (int)(item.Cells[2].Value);
                decimal subtotal = quantidade * valor;
                item.Cells[4].Value = subtotal;

                totalVenda += subtotal;
            }
            this.VendaCorrente.Valor = totalVenda;
        }

        private void btn_fin_pedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o pedido ?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btn_novoItem.Enabled = false;
                CB_produto.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_Desconto.ReadOnly = false;
                txt_Desconto.Focus();
                btn_fin_pedido.Enabled = false;
                btn_fin_venda.Enabled = true;
                txt_codigo.Enabled = false;
            }
        }

        private void btn_fin_venda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_Desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_Desconto.Enabled = false;
            btn_fin_venda.Enabled = false;


            CB_pagamento.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.Codigo;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }
        private void CB_pagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CB_pagamento.SelectedItem != null)
            {
                var status = (StatusPagamento)CB_pagamento.SelectedItem;

                if (status.Codigo == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.Codigo;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btn_finalizar.Enabled = true;
                    txt_data_vencimento.Enabled = false;

                }
                else if (status.Codigo == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.Codigo;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    txt_data_vencimento.Enabled = true;
                    btn_finalizar.Enabled = true;
                }
            }
        }
        private void btn_finalizar_Click_1(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            txt_data_vencimento.Enabled = true;
            btn_finalizar.Enabled = false;
            CB_pagamento.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com sucesso");
        }
    }
}
