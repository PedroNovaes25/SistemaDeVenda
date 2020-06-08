using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace Sistema
{
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource1.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource1.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (MessageBox.Show("Tem certeza? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.categoriaBindingSource1.EndEdit(); //Finaliza o processo de edição
                    DataContextFactory.DataContext.SubmitChanges(); // enviar as mudanças ao BD
                    MessageBox.Show("Categoria adicionada com sucesso");
                }
            } 
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //Mensage, nome da janela, pergunta y/n botões, resultado da pergunta == y ?
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.categoriaBindingSource1.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria removida com sucesso !");
            }
        }

        private bool Validar()
        {
            if (txt_categoria.Text.Trim() == string.Empty) //.Trim ignora os espaços
            {
                MessageBox.Show("O campo categoria é obrigatório");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource1.CancelEdit();
        }
    }
}
