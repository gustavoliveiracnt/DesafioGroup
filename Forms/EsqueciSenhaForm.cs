using Desafio_Group.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class EsqueciSenhaForm : Form
    {
        private string randomCode;
        public LoginForm LoginForm { get; set; }
        private BancoDados _bancoDados { get; }
        private Email _email { get; }
        public EsqueciSenhaForm()
        {
            InitializeComponent();
            _bancoDados = new BancoDados();
            _email = new Email();
            LoginForm = new LoginForm();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.Show();
        }

        private void enviarTokenButton_Click(object sender, EventArgs e)
        {
            if (_bancoDados.VerificarEmailBanco(recuperacaoEmail.Text.ToString())){
                try
                {
                    randomCode = _email.EnviarEmail(recuperacaoEmail.Text.ToString());
                }
                catch (Exception except)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar enviar o código para o e-mail: " +except.Message, "Erro ao enviar token", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado em nosso banco. ", "Erro ao encontrar e-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            if (randomCode != null && randomCode == tokenTxt.Text.ToString())
            {
                RedefinirSenhaForm redefinir = new RedefinirSenhaForm(recuperacaoEmail.Text.ToString());
                redefinir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Token incorreto. Favor verificar sua caixa de entrada. ", "Verifique Caixa de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
