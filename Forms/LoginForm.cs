using Desafio_Group.Forms;
using Desafio_Group.Validacoes;
using System;
using System.Windows.Forms;

namespace Desafio_Group
{
    public partial class LoginForm : Form
    {
        #region PROPRIEDADES
        public CadastroForm Cadastro  { get; set; }

        #endregion

        #region CONSTRUTORES
        public LoginForm()
        {
            InitializeComponent();
            Cadastro = new CadastroForm();
        }
        #endregion

        #region MÉTODOS

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            senhaTxt.PasswordChar = ShowPass.Checked ? '\0' : '*';
        }

        private void EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenhaForm esqueciSenha = new EsqueciSenhaForm();
            esqueciSenha.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Validacao.verificarLogin(usuarioTxt.Text.ToString(), senhaTxt.Text.ToString()))
            {
                Cadastro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado para acesso.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuarioTxt.Clear();
                senhaTxt.Clear();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
