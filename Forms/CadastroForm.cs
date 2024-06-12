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
using Desafio_Group.Funcionalidades;
namespace Desafio_Group.Forms

{
    public partial class CadastroForm : Form
    {
        BancoDados bancodados = new BancoDados();

        public CadastroForm()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'desafioGroupDataSet.TabelaCadastro'. Você pode movê-la ou removê-la conforme necessário.

            CarregarGrid();
        }

        private void TipoCPF_CheckedChanged(object sender, EventArgs e)
        {
            documentTxt.Mask = TipoCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
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

        //CRUD
        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (validarCampos() && verificarCampos())
            {
                try
                {
                    bancodados.Cadastrar(nomeTxt.Text.ToString(), documentTxt.Text.ToString(), telefoneTxt.Text.ToString(), emailTxt.Text.ToString(), enderecoTxt.Text.ToString());
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

        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                bancodados.Alterar(nomeTxt.Text.ToString(), documentTxt.Text.ToString(), telefoneTxt.Text.ToString(), emailTxt.Text.ToString(), enderecoTxt.Text.ToString());
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
                if (MessageBox.Show("Deseja excluir permanentemente esses dados?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bancodados.Deletar(documentTxt.Text.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            limparCampos();
            CarregarGrid();
        }

        //funcionalidades
        private void limparButton_Click(object sender, EventArgs e)
        {
            try
            {
                bancodados.Limpar(buscartxt, dataGrid);
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            limparCampos();
        }

        private void buscarCEP_Click(object sender, EventArgs e)
        {
            string cep = CEPMasked.Text.ToString();

            CEP buscar = new CEP();
            enderecoTxt.Text = buscar.BuscarCEP(cep);
        }

        private void limparCampos()
        {
            nomeTxt.Clear();
            documentTxt.Clear();
            telefoneTxt.Clear();
            emailTxt.Clear();
            CEPMasked.Clear();
            enderecoTxt.Clear();
            documentTxt.Enabled = true;
            buscartxt.Clear();
            TipoCPF.Checked = false;
            TipoCNPJ.Checked = false;
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
                bancodados.BuscarDocumento(buscartxt, dataGrid, nomeTxt, documentTxt, telefoneTxt, emailTxt, enderecoTxt, TipoCPF, TipoCNPJ);
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
                bancodados.BuscarNome(buscartxt, dataGrid, nomeTxt, documentTxt, telefoneTxt, emailTxt, enderecoTxt, TipoCPF, TipoCNPJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
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

    }
}
