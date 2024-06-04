using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desafio_Group.Validacoes;
namespace Desafio_Group.Forms
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioGroupDataSet.TabelaCadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaCadastroTableAdapter.Fill(this.desafioGroupDataSet.TabelaCadastro);

        }

        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            documentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            
            try {
                Validacao validacao = new Validacao();
                bool retorno;
                string mensagem;

                //validar campos vazios
                if (string.IsNullOrEmpty(nomeTxt.Text)){
                    MessageBox.Show("Por favor, informe seu nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nomeTxt.Focus();   return;
                }
                if (!TipoCPF.Checked && !TipoCNPJ.Checked)
                {
                    mensagem = "Por favor, marque campo 'TIPO' com uma das opções.";
                    MessageBox.Show("", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!documentTxt.MaskFull)
                {
                    MessageBox.Show("Por favor, informe número do documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    documentTxt.Focus(); return;
                }
                if (!telefoneTxt.MaskFull)
                {
                    MessageBox.Show("Por favor, informe número de telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    telefoneTxt.Focus(); return;
                }
                if (string.IsNullOrEmpty(emailTxt.Text))
                {
                    MessageBox.Show("Por favor, informe seu e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTxt.Focus(); return;
                }
                if (!CEPMasked.MaskFull)
                {
                    MessageBox.Show("Por favor, informe seu CEP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CEPMasked.Focus(); return;
                }

                ////verificar se é válido
                //if(TipoCPF.Checked)
                //{
                //    mensagem = validacao.validarCPF(documentTxt.Text.ToString()) ? "" : "CPF inválido."; 

                //    if(mensagem != "")
                //    {
                //        MessageBox.Show($"{mensagem}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        documentTxt.Focus(); return;
                //    }
                //}

                //if(TipoCNPJ.Checked)
                //{
                //    mensagem = validacao.validarCNPJ(documentTxt.Text.ToString()) ? null : "CNPJ inválido.";

                //    if (mensagem != null)
                //    {
                //        MessageBox.Show($"{mensagem}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        documentTxt.Focus(); return;
                //    }
                //}

                //if (!validacao.validarEmail(emailTxt.Text.ToString()))
                //{
                //    MessageBox.Show("E-mail inválido, informe novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    emailTxt.Focus(); return;
                //}

                //if(!validacao.validarCEP(CEPMasked.Text.ToString()))
                //{
                //    MessageBox.Show("CEP inválido, informe novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    emailTxt.Focus(); return;
                //}

            }
            catch(Exception except) { }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\gustavo.henrique\\OneDrive - Group Software Ltda\\Documentos\\DesafioGroup.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO TabelaCadastro (documento, nome, telefone, email, endereco) VALUES (@documento, @nome, @telefone, @email, @endereco)", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@documento", documentTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@nome", nomeTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@telefone", telefoneTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@endereco", enderecoTxt.Text.ToString());

                        sqlCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            documentTxt.Clear();
            nomeTxt.Clear();
            telefoneTxt.Clear();
            emailTxt.Clear();
            enderecoTxt.Clear();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\gustavo.henrique\\OneDrive - Group Software Ltda\\Documentos\\DesafioGroup.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE TabelaCadastro set nome=@nome, telefone=@telefone, email=@email, endereco=@endereco where documento=@documento", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@documento", documentTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@nome", nomeTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@telefone", telefoneTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@endereco", enderecoTxt.Text.ToString());

                        sqlCommand.ExecuteNonQuery();
                        
                    }

                    MessageBox.Show("Alteração realizada.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\gustavo.henrique\\OneDrive - Group Software Ltda\\Documentos\\DesafioGroup.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE TabelaCadastro where documento=@documento", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@documento", documentTxt.Text.ToString());

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o documento especificado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
