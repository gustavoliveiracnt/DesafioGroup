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
        private Validacao Validar { get; set; }
        public CadastroForm Cadastro  { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Validar = new Validacao();
            Cadastro = new CadastroForm();
        }

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
            if (Validar.verificarLogin(usuarioTxt.Text.ToString(), senhaTxt.Text.ToString()))
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
    }
}
