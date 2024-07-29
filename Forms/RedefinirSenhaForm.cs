using Desafio_Group.Funcionalidades;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class RedefinirSenhaForm : Form
    {
        #region ATRIBUTOS
        public string Usuario { get; set; }
        public LoginForm _loginForm { get; set; }

        #endregion

        #region CONSTRUTOR
        public RedefinirSenhaForm(string usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            _loginForm = new LoginForm();
        }

        #endregion

        #region MÉTODOS

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            if(novaSenha.Text == confirmacaoSenha.Text)
            {
                BancoDados db = new BancoDados();

                if(db.AlterarSenhaUsuario(Usuario, confirmacaoSenha.Text.ToString()))
                {
                    _loginForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Senhas diferentes. Alteração não pode ser realizada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novaSenha.Clear();
                confirmacaoSenha.Clear() ;
            }
        }

        private void mostrar_novaSenha_CheckedChanged(object sender, EventArgs e)
        {
            novaSenha.PasswordChar = mostrar_novaSenha.Checked ? '\0' : '*';
            confirmacaoSenha.PasswordChar = mostrar_novaSenha.Checked ? '\0' : '*';
        }

        #endregion

    }
}
