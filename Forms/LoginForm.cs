using Desafio_Group.Forms;
using Desafio_Group.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            senhaTxt.PasswordChar = ShowPass.Checked ? '\0' : '*';
        }

        private void EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenhaForm esqueciSenha = new EsqueciSenhaForm();
            esqueciSenha.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Validacao validar = new Validacao();
            if (validar.verificarLogin(usuarioTxt.Text.ToString(), senhaTxt.Text.ToString()))
            {
                CadastroForm cadastro = new CadastroForm();
                cadastro.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado para acesso.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuarioTxt.Clear();
                senhaTxt.Clear();
            }
        }
    }
}
