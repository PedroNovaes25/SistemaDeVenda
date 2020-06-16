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
    public partial class frm_login : Form
    {

        public bool logado = false;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            efetuarLogin();
        }

        private void efetuarLogin() 
        {
            var user = DataContextFactory.DataContext.Usuario.Count(x => x.usuario == txt_usuario.Text && x.senha == txt_senha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login inválido");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
