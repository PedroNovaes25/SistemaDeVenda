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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        #region #Botoes
            private void btn_cancelar_Click(object sender, EventArgs e)
            {
                this.produtoBindingSource.CancelEdit();
            }
            private void btn_excluir_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Tem certeza ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.produtoBindingSource.RemoveCurrent(); //remove selecionado
                    DataContextFactory.DataContext.SubmitChanges(); //envia as mudanças ao BD
                    MessageBox.Show("Produto removido com sucesso!");
                }
            }
            private void btn_cadastrar_Click(object sender, EventArgs e)
            {
                if (Validar())
                {
                    if (MessageBox.Show("Tem certeza ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        this.produtoBindingSource.EndEdit();
                        DataContextFactory.DataContext.SubmitChanges();
                        MessageBox.Show("Produto adicionado com sucesso!");
                    }
                } 
            }
            private void btn_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }
        #endregion

        #region #Validacao
        private bool Validar() 
        {
            if (txt_descricao.Text.Trim() == String.Empty | txt_valor.Text.Trim() == String.Empty | CB_categoria.Text.Trim() == String.Empty) 
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
                return false;
            }
            return true;
        }
        #endregion

        private void dataGrid_produtos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex ==3)
            {
                e.Value = ((Categoria)e.Value).Descricao;
            }
        }
    }
}
