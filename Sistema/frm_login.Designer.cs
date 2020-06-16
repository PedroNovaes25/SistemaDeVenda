namespace Sistema
{
    partial class frm_login
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.btn_logar = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            usuarioLabel.Location = new System.Drawing.Point(144, 102);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(64, 18);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            senhaLabel.Location = new System.Drawing.Point(149, 140);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(54, 18);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha:";
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.Transparent;
            this.btn_logar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logar.Image = global::Sistema.Properties.Resources.icone_login_20x20;
            this.btn_logar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logar.Location = new System.Drawing.Point(182, 191);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(88, 32);
            this.btn_logar.TabIndex = 0;
            this.btn_logar.Text = "Logar";
            this.btn_logar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(sistema.DAL.Usuario);
            // 
            // txt_usuario
            // 
            this.txt_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario", true));
            this.txt_usuario.Location = new System.Drawing.Point(221, 103);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(120, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha", true));
            this.txt_senha.Location = new System.Drawing.Point(221, 141);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(120, 20);
            this.txt_senha.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Image = global::Sistema.Properties.Resources.sair_20x20;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(301, 191);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(88, 32);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema.Properties.Resources.fundo_sistema_azul;
            this.ClientSize = new System.Drawing.Size(561, 305);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_logar);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_cancelar;
    }
}