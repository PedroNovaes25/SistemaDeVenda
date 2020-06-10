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
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void frm_consultaCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int  codigoCategoria = (int)CB_categoria.SelectedValue;
            Pesquisa(codigoCategoria);
        }

        public void Pesquisa(int codigoCategoria) 
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto.Where(x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
