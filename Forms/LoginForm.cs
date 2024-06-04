using Desafio_Group.Forms;
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
            senha.PasswordChar = ShowPass.Checked ? '\0' : '*';
        }

        private void EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenhaForm esqueciSenha = new EsqueciSenhaForm();
            esqueciSenha.ShowDialog();
        }
    }
}
