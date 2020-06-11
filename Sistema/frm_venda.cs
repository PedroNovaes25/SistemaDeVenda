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
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;

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

        private void btn_novaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novaVenda.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda;
            NovoItem();
        }

        private void NovoItem() 
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.Codigo;
            this.ItemCorrente.Quantidade = 1;
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
    }
}
