using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class RedefinirSenhaForm : Form
    {
        public RedefinirSenhaForm()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            //realizar restante de validações no banco de dados
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            if(novaSenha.Text == confirmacaoSenha.Text)
            {
                MessageBox.Show("Senhas iguais. Alteração pode ser realizada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
