using Desafio_Group.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Desafio_Group.Funcionalidades
{
    internal class BancoDados
    {
        private SqlConnection conexao = null;

        private string stringConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GroupDF;Data Source=GROUP-NOTE02229\SQLEXPRESS2019";

        private string stringSql = string.Empty;

        private Hash hash = new Hash(SHA256.Create());

        public Hash Hash { get {  return hash; } set { hash = value; } }


        public void Deletar(string documento)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
            {
                sqlConnection.Open();
                stringSql = "DELETE FROM Cadastro where documento=@documento";
                using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@documento", documento);

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

        public void Cadastrar(string nome, string documento, string telefone, string email, string endereco)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "INSERT INTO Cadastro (nome, documento, telefone, email, endereco) VALUES (@nome, @documento, @telefone, @email, @endereco)";
                    using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nome", nome);
                        sqlCommand.Parameters.AddWithValue("@documento", documento);
                        sqlCommand.Parameters.AddWithValue("@telefone", telefone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@endereco", endereco);

                        sqlCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar pessoa: " + ex.Message, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar(string nome, string documento, string telefone, string email, string endereco)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
            {
                sqlConnection.Open();

                stringSql = "UPDATE Cadastro set nome=@nome, telefone=@telefone, email=@email, endereco=@endereco where documento=@documento";

                using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("@nome", nome);
                    sqlCommand.Parameters.AddWithValue("@documento", documento);
                    sqlCommand.Parameters.AddWithValue("@telefone", telefone);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@endereco", endereco);

                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Alteração realizada.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BuscarDocumento(MaskedTextBox buscaTxt, DataGridView dataGrid, TextBox nomeTxt, MaskedTextBox documentTxt, MaskedTextBox telefoneTxt, TextBox emailTxt, TextBox enderecoTxt, RadioButton TipoCPF, RadioButton TipoCNPJ)
        {
            string busca = buscaTxt.Text.ToString();
            if (string.IsNullOrWhiteSpace(busca))
            {
                MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buscaTxt.Focus();
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
            {
                sqlConnection.Open();

                stringSql = "SELECT * FROM Cadastro WHERE documento = @documento";

                using (SqlDataAdapter da = new SqlDataAdapter(stringSql, sqlConnection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@documento", busca);

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGrid.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            buscaTxt.Focus();
                            return;
                        }
                        else
                        {
                            using (SqlCommand command = new SqlCommand(stringSql, sqlConnection))
                            {
                                command.Parameters.AddWithValue("@documento", busca);

                                using (SqlDataReader dr = command.ExecuteReader())
                                {
                                    if (dr.HasRows)
                                    {
                                        if (dr.Read())
                                        {
                                            nomeTxt.Text = dr["nome"].ToString();
                                            documentTxt.Text = dr["documento"].ToString();

                                            telefoneTxt.Text = dr["telefone"].ToString();
                                            emailTxt.Text = dr["email"].ToString();
                                            enderecoTxt.Text = dr["endereco"].ToString();

                                            if (dr["documento"].ToString().Length == 14)
                                            {
                                                TipoCPF.Checked = true;
                                                documentTxt.Mask = @"000\.000\.000\-00";
                                            }
                                            else
                                            {
                                                TipoCNPJ.Checked = true;
                                                documentTxt.Mask = @"00\.000\.000\/0000\-00";
                                            }
                                            documentTxt.Text = dr["documento"].ToString();
                                            documentTxt.Enabled = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void BuscarNome(MaskedTextBox buscaTxt, DataGridView dataGrid, TextBox nomeTxt, MaskedTextBox documentTxt, MaskedTextBox telefoneTxt, TextBox emailTxt, TextBox enderecoTxt, RadioButton TipoCPF, RadioButton TipoCNPJ)
        {
            string busca = buscaTxt.Text.ToString();
            if (string.IsNullOrWhiteSpace(busca))
            {
                MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buscaTxt.Focus();
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
            {
                sqlConnection.Open();

                stringSql = "SELECT * FROM Cadastro WHERE nome = @nome";

                using (SqlDataAdapter da = new SqlDataAdapter(stringSql, sqlConnection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nome", busca);

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGrid.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            buscaTxt.Focus();
                            return;
                        }
                        else
                        {
                            using (SqlCommand command = new SqlCommand(stringSql, sqlConnection))
                            {
                                command.Parameters.AddWithValue("@nome", busca);

                                using (SqlDataReader dr = command.ExecuteReader())
                                {
                                    if (dr.HasRows)
                                    {
                                        if (dr.Read())
                                        {
                                            nomeTxt.Text = dr["nome"].ToString();
                                            telefoneTxt.Text = dr["telefone"].ToString();
                                            emailTxt.Text = dr["email"].ToString();
                                            enderecoTxt.Text = dr["endereco"].ToString();

                                            if (dr["documento"].ToString().Length == 14)
                                            {
                                                TipoCPF.Checked = true;
                                                documentTxt.Mask = @"000\.000\.000\-00";
                                            }
                                            else
                                            {
                                                TipoCNPJ.Checked = true;
                                                documentTxt.Mask = @"00\.000\.000\/0000\-00";
                                            }
                                            documentTxt.Text = dr["documento"].ToString();
                                            documentTxt.Enabled = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Limpar(MaskedTextBox buscaTxt, DataGridView dataGrid)
        {
            string busca = buscaTxt.Text.ToString();
            if (string.IsNullOrWhiteSpace(busca))
            {
                MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buscaTxt.Focus();
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
            {
                sqlConnection.Open();

                string stringSql = "SELECT * FROM Cadastro";

                using (SqlDataAdapter da = new SqlDataAdapter(stringSql, sqlConnection))
                {

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGrid.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            buscaTxt.Focus();
                            return;
                        }
                    }
                }
            }
        }

        public void CarregarGrid(DataGridView dataGrid)
        {

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                stringSql = "SELECT * FROM dbo.Cadastro";
                using (SqlDataAdapter da = new SqlDataAdapter(stringSql, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }

        public bool VerificarLoginBanco(string LoginBanco, string senhaBanco)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();
                    stringSql = "select * from Acesso where usuario=@login and password=@senha";

                    using (SqlCommand cmd = new SqlCommand(stringSql, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@login", LoginBanco);
                        cmd.Parameters.AddWithValue("@senha", Hash.Criptografar(senhaBanco));
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                string senha = dr["password"].ToString();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show("Ocorreu um erro com acesso ao banco de dados: " + exept.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool VerificarEmailBanco(string email)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();
                    stringSql = "select * from Acesso where usuario=@login";

                    using (SqlCommand cmd = new SqlCommand(stringSql, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@login", email);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception exept)
            {
                MessageBox.Show("Ocorreu um erro com acesso ao banco de dados: " + exept.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool AlterarSenhaUsuario(string login, string senha)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "UPDATE Acesso set password=@senha where usuario=@login";

                    using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
                    {

                        sqlCommand.Parameters.AddWithValue("@senha", Hash.Criptografar(senha));
                        sqlCommand.Parameters.AddWithValue("@login", login);

                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Senha alterada com sucesso.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch(Exception exept)
            {
                MessageBox.Show("Ocorreu um erro inesperado: "+exept.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }

        }
    }
}
