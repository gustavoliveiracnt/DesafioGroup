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
using System.Globalization;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
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

            CarregarGrid();
        }

        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            documentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (validarCampos() && verificarCampos())
            {
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
            CarregarGrid();
        }

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
            CarregarGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();
                    stringSql = "DELETE FROM Cadastro where documento=@documento";
                    using (SqlCommand sqlCommand = new SqlCommand(stringSql, sqlConnection))
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
            CarregarGrid();
        }

        private void limparCampos()
        {
            nomeTxt.Clear();
            documentTxt.Clear();
            telefoneTxt.Clear();
            emailTxt.Clear();
            CEPMasked.Clear();
            enderecoTxt.Clear();
            buscartxt.Clear();
            CPFBusca.Checked = false;
            CNPJBusca.Checked = false;
            nomeBusca.Checked = false;
        }
        
        private bool verificarCampos()
        {

            if (string.IsNullOrEmpty(nomeTxt.Text))
            {
                MessageBox.Show("Por favor, informe nome para cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buscar_Documento()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(buscartxt.Text))
                {
                    MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buscartxt.Focus();
                    return;
                }

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "SELECT * FROM Cadastro WHERE documento = @documento";

                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql, sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@documento", buscartxt.Text);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                buscartxt.Focus();
                                return;
                            }
                            else
                            {
                                using (SqlCommand command = new SqlCommand(stringSql, sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@documento", buscartxt.Text);

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
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void buscar_Nome()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(buscartxt.Text))
                {
                    MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buscartxt.Focus();
                    return;
                }

                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    stringSql = "SELECT * FROM Cadastro WHERE nome = @nome";

                    using (SqlDataAdapter da = new SqlDataAdapter(stringSql, sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@nome", buscartxt.Text);

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGrid.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Não há nenhum cadastro na tabela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                buscartxt.Focus();
                                return;
                            }
                            else
                            {
                                using (SqlCommand command = new SqlCommand(stringSql, sqlConnection))
                                {
                                    command.Parameters.AddWithValue("@nome", buscartxt.Text);

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
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (!nomeBusca.Checked)
            {
               buscar_Documento();
            }
            else
            {
                buscar_Nome();
            }
        }

        private void CPFBusca_CheckedChanged(object sender, EventArgs e)
        {

            if (CPFBusca.Checked)
            {
                buscartxt.Mask = @"000\.000\.000\-00";
            }
            else if (CNPJBusca.Checked)
            {
                buscartxt.Mask = @"00\.000\.000\/0000\-00";
            }
            else
            {
                buscartxt.Mask = "";
            }

        }

        private void CarregarGrid()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(buscartxt.Text))
                {
                    MessageBox.Show("Campo precisa estar preenchido para realizar busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buscartxt.Focus();
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
                                buscartxt.Focus();
                                return;
                            }
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

        /*private void GetDadosDocumento(string documento)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConexao))
                {
                    sqlConnection.Open();

                    string stringSql = "SELECT * FROM Cadastro WHERE documento = @documento";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }*/

    }
}
