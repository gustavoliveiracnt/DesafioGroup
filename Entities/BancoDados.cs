using Desafio_Group.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Desafio_Group.Funcionalidades
{
    internal class BancoDados
    {
        #region ATRIBUTOS
        private SqlConnection conexao = null;

        private StringBuilder stringConexao = new StringBuilder(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GroupDF;Data Source=GROUP-NOTE02229\SQLEXPRESS2019");

        private StringBuilder stringSql = new StringBuilder();

        private Hash hash = new Hash(SHA256.Create());

        public Hash Hash
        {
            get
            {
                return hash;
            }
            set
            {
                hash = value;
            }
        }
        #endregion

        #region CRUD
        public bool Deletar(string documento)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();
                    stringSql.Append("DELETE FROM Cadastro where documento=@documento");
                    using (SqlCommand sqlCommand = new SqlCommand(stringSql.ToString(), sqlConnection))
                    {

                        sqlCommand.Parameters.AddWithValue("@documento", documento);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            stringSql.Clear();
                            return true;
                            //MessageBox.Show("Deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Nenhum registro encontrado com o documento especificado.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Cadastrar(Pessoa pessoa)
        {
            try
            {
                StringBuilder stringSql = new StringBuilder();

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("INSERT INTO Cadastro (nome, documento, telefone, email, endereco) VALUES (@nome, @documento, @telefone, @email, @endereco);");

                    using (SqlCommand sqlCommand = new SqlCommand(stringSql.ToString(), sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
                        sqlCommand.Parameters.AddWithValue("@documento", pessoa.Documento);
                        sqlCommand.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                        sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
                        sqlCommand.Parameters.AddWithValue("@endereco", pessoa.Endereco);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                stringSql.Clear();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao cadastrar pessoa: " + ex.Message);
            }
        }

        public bool Alterar(Pessoa pessoa)
        {
            try
            {
                StringBuilder stringSql = new StringBuilder();

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("UPDATE Cadastro SET nome = @nome, telefone = @telefone, email = @email, endereco = @endereco WHERE documento = @documento;");

                    using (SqlCommand sqlCommand = new SqlCommand(stringSql.ToString(), sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
                        sqlCommand.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                        sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
                        sqlCommand.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                        sqlCommand.Parameters.AddWithValue("@documento", pessoa.Documento);

                        sqlCommand.ExecuteNonQuery();
                    }
                }

                stringSql.Clear();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar os dados. \nErro: " + ex.Message);
            }
        }

        public bool BuscarDocumento(string busca, DataGridView dataGrid, Pessoa pessoa)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("SELECT * FROM Cadastro WHERE documento = @documento");

                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql.ToString(), sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@documento", busca);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                throw new Exception("Não há nenhum cadastro na tabela.");
                            }
                            else
                            {
                                using (SqlCommand command = new SqlCommand(stringSql.ToString(), sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@documento", busca);

                                    using (SqlDataReader dr = command.ExecuteReader())
                                    {
                                        if (dr.HasRows)
                                        {
                                            if (dr.Read())
                                            {
                                                pessoa.Nome = dr["nome"].ToString();
                                                pessoa.Documento = dr["documento"].ToString();
                                                pessoa.Telefone = dr["telefone"].ToString();
                                                pessoa.Email = dr["email"].ToString();
                                                pessoa.Endereco = dr["endereco"].ToString();
                                                pessoa.Documento = dr["documento"].ToString();

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                stringSql.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //tratamento exceção
            }
        }

        public bool BuscarNome(string busca, DataGridView dataGrid, Pessoa pessoa)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("SELECT * FROM Cadastro WHERE nome = @nome");

                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql.ToString(), sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@nome", busca);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                throw new Exception("Não há nenhum cadastro na tabela.");

                            }
                            else
                            {
                                using (SqlCommand command = new SqlCommand(stringSql.ToString(), sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@nome", busca);

                                    using (SqlDataReader dr = command.ExecuteReader())
                                    {
                                        if (dr.HasRows)
                                        {
                                            if (dr.Read())
                                            {
                                                pessoa.Nome = dr["nome"].ToString();
                                                pessoa.Telefone = dr["telefone"].ToString();
                                                pessoa.Email = dr["email"].ToString();
                                                pessoa.Endereco = dr["endereco"].ToString();
                                                pessoa.Documento = dr["documento"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                stringSql.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //tratamento de exceção caso tenha
            }

        }

        #endregion

        #region MÉTODOS ADICIONAIS

        //public void Limpar(MaskedTextBox buscaTxt, DataGridView dataGrid)
        //{
        //    string busca = buscaTxt.Text.ToString();

        //    using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
        //    {
        //        sqlConnection.Open();

        //        stringSql.Append("SELECT * FROM Cadastro");

        //        using (SqlDataAdapter da = new SqlDataAdapter(stringSql.ToString(), sqlConnection))
        //        {

        //            using (DataTable dt = new DataTable())
        //            {
        //                da.Fill(dt);
        //                dataGrid.DataSource = dt;

        //                if (dt.Rows.Count == 0)
        //                {
        //                    buscaTxt.Focus();
        //                    throw new Exception("Não há nenhum cadastro na tabela.");
        //                    //MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }
        //        }
        //    }
        //}

        public bool VerificarLoginBanco(string LoginBanco, string senhaBanco)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();
                    stringSql.Append("select * from Acesso where usuario=@login and password=@senha");

                    using (SqlCommand cmd = new SqlCommand(stringSql.ToString(), sqlConnection))
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
                stringSql.Clear();
            }
            catch (Exception exept)
            {
                throw new Exception("Ocorreu um erro com acesso ao banco de dados: " + exept.Message);
            }

            return false;
        }
        public bool VerificarCadastro(DataGridView dataGrid, Pessoa pessoa)
        {
            bool retorno = true;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("SELECT * FROM Cadastro WHERE documento = @documento");

                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql.ToString(), sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@documento", pessoa.Documento);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                retorno = false;
                            }
                        }
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Exceção ao consultar cadastros. Erro: " + ex.Message);
            }
        }
        public bool AlterarSenhaUsuario(string login, string senha)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();

                    stringSql.Append("UPDATE Acesso set password=@senha where usuario=@login");

                    using (SqlCommand sqlCommand = new SqlCommand(stringSql.ToString(), sqlConnection))
                    {

                        sqlCommand.Parameters.AddWithValue("@senha", Hash.Criptografar(senha));
                        sqlCommand.Parameters.AddWithValue("@login", login);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                stringSql.Clear();
                return true;
            }
            catch (Exception exept)
            {
                throw new Exception("Ocorreu um erro inesperado: " + exept.Message);
            }

        }
        public void CarregarGrid(DataGridView dataGrid)
        {
            stringSql = new StringBuilder();
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringConexao.ToString()))
                {
                    conexao.Open();
                    stringSql.Append("SELECT * FROM dbo.Cadastro");
                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql.ToString(), conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;
                        }
                    }
                }
                stringSql.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Ococrreu um erro ao carregar Grid. \nErro: " + ex.Message);
            }
        }
        public bool VerificarEmailBanco(string email)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao.ToString()))
                {
                    sqlConnection.Open();
                    stringSql.Append("select * from Acesso where usuario=@login");

                    using (SqlCommand cmd = new SqlCommand(stringSql.ToString(), sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@login", email);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        }
                    }
                }
                stringSql.Clear();
            }
            catch (Exception exept)
            {
                throw new Exception("Ocorreu um erro com acesso ao banco de dados: " + exept.Message);
            }

            return false;
        }



        #endregion
    }
}
