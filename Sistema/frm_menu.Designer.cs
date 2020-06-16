namespace Sistema
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btb_cad_produtos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btb_cad_produtos
            // 
            this.btb_cad_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btb_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btb_cad_produtos.FlatAppearance.BorderSize = 0;
            this.btb_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btb_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btb_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btb_cad_produtos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btb_cad_produtos.Image = global::Sistema.Properties.Resources.cadastro_produtos_40_x_40;
            this.btb_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btb_cad_produtos.Location = new System.Drawing.Point(27, 80);
            this.btb_cad_produtos.Name = "btb_cad_produtos";
            this.btb_cad_produtos.Size = new System.Drawing.Size(88, 74);
            this.btb_cad_produtos.TabIndex = 1;
            this.btb_cad_produtos.Text = "Cadastrar Produtos";
            this.btb_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btb_cad_produtos.UseVisualStyleBackColor = false;
            this.btb_cad_produtos.Click += new System.EventHandler(this.btb_cad_produtos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.categoriaToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.produtosToolStripMenuItem.Text = "Cadastrados";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos/Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.BorderSize = 0;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cad_categorias.Image = global::Sistema.Properties.Resources.faturas_40x40;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(121, 80);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(88, 74);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar Categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.btn_cad_categorias_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema.Properties.Resources.fundo_sistema_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(568, 314);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btb_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btb_cad_produtos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}

