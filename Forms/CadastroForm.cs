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

        SqlConnection conexao = null;
        private string stringConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GroupDF;Data Source=GROUP-NOTE02229\SQLEXPRESS2019";
        private string stringSql = string.Empty;

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioGroupDataSet.TabelaCadastro'. Você pode movê-la ou removê-la conforme necessário.
        }

        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            documentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (validarCampos() && verificarCampos()) {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                    {
                        sqlConnection.Open();

                        stringSql = "INSERT INTO Cadastro (nome, documento, telefone, email, endereco) VALUES (@nome, @documento, @telefone, @email, @endereco)";
                        using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                        {

                            sqlCommand.Parameters.AddWithValue("@nome", nomeTxt.Text.ToString());
                            sqlCommand.Parameters.AddWithValue("@documento", documentTxt.Text.ToString());
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
            }
            else
                MessageBox.Show("Impossível realizar cadastro, há algum campo não preenchido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            limparCampos();
        }

        //parei aqui
        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "UPDATE Cadastro set nome=@nome, telefone=@telefone, email=@email, endereco=@endereco where documento=@documento";
                    using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                    {

                        sqlCommand.Parameters.AddWithValue("@nome", nomeTxt.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@documento", documentTxt.Text.ToString());
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
            limparCampos();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\gustavo.henrique\\OneDrive - Group Software Ltda\\Documentos\\DesafioGroup.mdf\";Integrated Security=True;Connect Timeout=30"))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM TabelaCadastro where documento=@documento", sqlConnection))
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
            limparCampos();
        }

        private void limparCampos()
        {
            nomeTxt.Clear();
            documentTxt.Clear();
            telefoneTxt.Clear();
            emailTxt.Clear();
            enderecoTxt.Clear();
        }

        private bool verificarCampos()
        {

            if (string.IsNullOrEmpty(nomeTxt.Text))
            {
                MessageBox.Show("Por favor, informe seu nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomeTxt.Focus(); return false;
            }
            if (!TipoCPF.Checked && !TipoCNPJ.Checked)
            {
                MessageBox.Show("Por favor, marque campo 'TIPO' com uma das opções.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!documentTxt.MaskFull)
            {
                MessageBox.Show("Por favor, informe número do documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                documentTxt.Focus(); return false;
            }
            if (!telefoneTxt.MaskFull)
            {
                MessageBox.Show("Por favor, informe número de telefone.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telefoneTxt.Focus(); return false;
            }
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                MessageBox.Show("Por favor, informe seu e-mail.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus(); return false;
            }
            if (!CEPMasked.MaskFull)
            {
                MessageBox.Show("Por favor, informe seu CEP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CEPMasked.Focus(); return false;
            }

            return true;
        }

        private bool validarCampos()
        {
            Validacao validacao = new Validacao();
            string mensagem;

            if (TipoCPF.Checked)
            {
                mensagem = validacao.validarCPF(documentTxt.Text.ToString()) ? null : "CPF inválido.";

                if (mensagem != null)
                {
                    MessageBox.Show($"{mensagem}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    documentTxt.Focus(); return false;
                }
            }
            else if (TipoCNPJ.Checked)
            {
                mensagem = validacao.validarCNPJ(documentTxt.Text.ToString()) ? null : "CNPJ inválido.";

                if (mensagem != null)
                {
                    MessageBox.Show($"{mensagem}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    documentTxt.Focus(); return false;
                }
            }

            if (!validacao.validarEmail(emailTxt.Text.ToString()))
            {
                MessageBox.Show("E-mail inválido, informe novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus(); return false;
            }

            if (!validacao.validarCEP(CEPMasked.Text.ToString()))
            {
                MessageBox.Show("CEP inválido, informe novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus(); return false;
            }

            return true;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "select * from Cadastro where documento = @documento";
                    SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection);

                    if (buscartxt.Text == string.Empty)
                    {
                        MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        emailTxt.Focus(); return;
                    }
                    
                    SqlDataReader dr = sqlCommand.ExecuteReader();

                    if(dr.HasRows == false)
                    {
                        MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        emailTxt.Focus(); return;
                    }

                    nomeTxt.Text = Convert.ToString(dr["nome"]);
                    documentTxt.Text = Convert.ToString(dr["documento"]);
                    telefoneTxt.Text = Convert.ToString(dr["telefone"]);
                    emailTxt.Text = Convert.ToString(dr["email"]);
                    enderecoTxt.Text = Convert.ToString(dr["endereco"]);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            limparCampos();

        }
    }
}
