using Desafio_Group.Entities;
using Desafio_Group.Funcionalidades;
using Desafio_Group.Validacoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Desafio_Group.Forms

{
    public partial class CadastroForm : Form
    {
        #region ATRIBUTOS
        private BancoDados bancodados = new BancoDados();
        private ErrorProvider errorProvider = new ErrorProvider();
        private List<string> errors = new List<string>();
        #endregion

        #region CONSTRUTORES
        public CadastroForm()
        {
            InitializeComponent();
        }
        #endregion

        #region CRUD
        private void salvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaProvedoresErro();
                if (ValidarErros())
                {
                    Pessoa consulta = GerarPessoa();
                    if (bancodados.VerificarCadastro(dataGrid, consulta))
                    {
                        bancodados.Alterar(consulta);
                    }
                    else
                        bancodados.Cadastrar(consulta);
                    LimparCampos();
                    CarregarGrid();
                }
                else
                    MessageBox.Show("Impossível realizar cadastro, há campos obrigatórios não preenchido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Deseja excluir permanentemente esses dados?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bancodados.Deletar(documentTxt.Text.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            LimparCampos();
            CarregarGrid();
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            if (!nomeBusca.Checked)
            {
                Buscar_Documento();
            }
            else
            {
                Buscar_Nome();
            }
        }
        #endregion

        #region MÉTODOS
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];

                this.nomeTxt.Text = row.Cells[0].Value.ToString();

                string document = row.Cells[1].Value.ToString();
                if (document.Length == 14)
                {
                    TipoCPF.Checked = true;
                    documentTxt.Mask = @"000\.000\.000\-00";
                }
                else
                {
                    TipoCNPJ.Checked = true;
                    documentTxt.Mask = @"00\.000\.000\/0000\-00";
                }

                this.documentTxt.Text = document;
                documentTxt.Enabled = false;
                this.telefoneTxt.Text = row.Cells[2].Value.ToString();
                this.emailTxt.Text = row.Cells[3].Value.ToString();
                this.enderecoTxt.Text = row.Cells[4].Value.ToString();
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
        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            documentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }
        private void btnViewLocal_Click(object sender, EventArgs e)
        {
            FormEndereco endereco = new FormEndereco();
            endereco.ShowDialog();
            if (string.IsNullOrEmpty(enderecoTxt.Text))
            {
                string retorno = string.Empty;
                endereco.btnSalvar_Click(ref retorno);
                enderecoTxt.Text = retorno;

            }
        }
        private void LimparButton_Click(object sender, EventArgs e)
        {
            try
            {
                buscartxt.Clear();
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            LimparCampos();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioGroupDataSet.TabelaCadastro'. Você pode movê-la ou removê-la conforme necessário.

            CarregarGrid();
        }
        public void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CarregarCampos(Pessoa pessoa)
        {
            this.nomeTxt.Text = pessoa.Nome;
            this.documentTxt.Text = pessoa.Documento;
            this.telefoneTxt.Text = pessoa.Telefone;
            this.emailTxt.Text = pessoa.Email;
            this.enderecoTxt.Text = pessoa.Endereco;
        }
        private List<string> ListarCampos()
        {
            List<string> dados = new List<string>();
            dados.Add(this.nomeTxt.Text);
            dados.Add(this.documentTxt.Text);
            dados.Add(this.telefoneTxt.Text);
            dados.Add(this.emailTxt.Text);
            dados.Add(this.enderecoTxt.Text);
            return dados;
        }
        private void LimpaProvedoresErro()
        {
            errorProvider.SetError(this.nomeTxt, string.Empty);
            errorProvider.SetError(this.DocumentoLabel, string.Empty);
            errorProvider.SetError(this.tpDocument, string.Empty);
            errorProvider.SetError(this.telefoneTxt, string.Empty);
            errorProvider.SetError(this.emailTxt, string.Empty);
            errorProvider.SetError(this.enderecoTxt, string.Empty);
            enderecoTxt.Size = new System.Drawing.Size(257, 22);

        }
        private void Buscar_Documento()
        {
            if (string.IsNullOrWhiteSpace(buscartxt.Text))
            {
                buscartxt.Focus();
                throw new Exception("Campo precisa estar preenchido para realizar busca.");
            }
            else
            {
                try
                {
                    Pessoa dadosPessoa = new Pessoa();
                    bool retorno = bancodados.BuscarDocumento(buscartxt.Text, dataGrid, dadosPessoa);
                    if (retorno)
                    {
                        if (dadosPessoa.Documento.Length == 14)
                        {
                            TipoCPF.Checked = true;
                            documentTxt.Mask = @"000\.000\.000\-00";
                        }
                        else
                        {
                            TipoCNPJ.Checked = true;
                            documentTxt.Mask = @"00\.000\.000\/0000\-00";
                        }
                        CarregarCampos(dadosPessoa);
                        documentTxt.Enabled = false;
                    }
                    dadosPessoa = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
        private Pessoa GerarPessoa()
        {
            try
            {
                Pessoa gerandoDados = new Pessoa(ListarCampos());
                return gerandoDados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro com os dados inseridos. \nErro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void LimparCampos()
        {
            nomeTxt.Clear();
            documentTxt.Clear();
            telefoneTxt.Clear();
            emailTxt.Clear();
            enderecoTxt.Clear();
            documentTxt.Enabled = true;
            buscartxt.Clear();
            TipoCPF.Checked = false;
            TipoCNPJ.Checked = false;
            CPFBusca.Checked = false;
            CNPJBusca.Checked = false;
            nomeBusca.Checked = false;
        }
        private void CarregarGrid()
        {
            try
            {
                bancodados.CarregarGrid(dataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private bool ValidarErros()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(nomeTxt.Text))
            {
                errorProvider.SetError(nomeTxt, "Nome para registro é um campo obrigatório.");
                retorno = false;
            }

            if (!TipoCPF.Checked && !TipoCNPJ.Checked)
            {
                errorProvider.SetError(tpDocument, "Tipo do documento é obrigatório, selecione uma das opções abaixo.");
                retorno = false;
            }
            else if (TipoCPF.Checked && !Validacao.validarCPF(documentTxt.Text))
            {
                errorProvider.SetError(DocumentoLabel, "Documento fornecida é inválido.");
                retorno = false;
            }
            else if (TipoCNPJ.Checked && !Validacao.validarCNPJ(documentTxt.Text))
            {
                errorProvider.SetError(DocumentoLabel, "Documento fornecida é inválido.");
                retorno = false;
            }

            if (string.IsNullOrEmpty(telefoneTxt.Text))
            {
                errorProvider.SetError(telefoneTxt, "Telefone para registro é um campo obrigatório.");
                retorno = false;
            }

            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                errorProvider.SetError(emailTxt, "E-mail para registro é um campo obrigatório.");
                retorno = false;
            }
            else if (!Validacao.validarEmail(this.emailTxt.Text))
            {
                errorProvider.SetError(emailTxt, "Formato do e-mail está incorreto.");
                retorno = false;
            }

            if (string.IsNullOrEmpty(enderecoTxt.Text))
            {
                errorProvider.SetError(enderecoTxt, "Endereço para registro é um campo obrigatório, por favor utilize o campo CEP para buscar.");
                retorno = false;
                enderecoTxt.Size = new System.Drawing.Size(235, 22);
            }

            return retorno;
        }
        private void Buscar_Nome()
        {
            if (string.IsNullOrWhiteSpace(buscartxt.Text))
            {
                buscartxt.Focus();
                throw new Exception("Campo precisa estar preenchido para realizar busca.");
            }
            else
            {
                try
                {
                    Pessoa dadosPessoa = new Pessoa();
                    bool retorno = bancodados.BuscarNome(buscartxt.Text, dataGrid, dadosPessoa);

                    if (retorno)
                    {
                        if (dadosPessoa.Documento.Length == 14)
                        {
                            TipoCPF.Checked = true;
                            documentTxt.Mask = @"000\.000\.000\-00";
                        }
                        else
                        {
                            TipoCNPJ.Checked = true;
                            documentTxt.Mask = @"00\.000\.000\/0000\-00";
                        }
                        CarregarCampos(dadosPessoa);
                        documentTxt.Enabled = false;
                    }
                    dadosPessoa = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }


        #endregion

    }
}
