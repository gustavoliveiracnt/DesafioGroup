using Desafio_Group.Funcionalidades;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class EsqueciSenhaForm : Form
    {
        #region ATRIBUTOS
        private string randomCode;
        public LoginForm LoginForm { get; set; }
        private BancoDados _bancoDados { get; }
        private Email _email { get; }

        #endregion

        #region CONSTRUTOR
        public EsqueciSenhaForm()
        {
            InitializeComponent();
            _bancoDados = new BancoDados();
            _email = new Email();
            LoginForm = new LoginForm();
        }

        #endregion

        #region MÉTODOS
        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.Show();
        }

        private void enviarTokenButton_Click(object sender, EventArgs e)
        {
            if (_bancoDados.VerificarEmailBanco(recuperacaoEmail.Text)){
                try
                {
                    _email.EnviarEmail(recuperacaoEmail.Text, ref randomCode);
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                RedefinirSenhaForm redefinir = new RedefinirSenhaForm(recuperacaoEmail.Text);
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
        #endregion
    }
}
