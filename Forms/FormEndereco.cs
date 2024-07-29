using Desafio_Group.Entities;
using Desafio_Group.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class FormEndereco : Form
    {
        #region ATRIBUTOS
        public Endereco endereco = new Endereco();
        #endregion
        public FormEndereco()
        {
            InitializeComponent();
        }

        public FormEndereco(string cep)
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PreencherCampos(Endereco endereco)
        {
            logradourotxt.Text = endereco.Logradouro;
            complementotxt.Text = endereco.Complemento;
            numerotxt.Text = endereco.Numero;
            bairrotxt.Text = endereco.Bairro;
            localidadetxt.Text = endereco.Localidade;
            uftxt.Text = endereco.UF;
        }

        public void btnSalvar_Click(ref string end)
        {
            try
            {
                endereco.Numero = numerotxt.Text;
                endereco.Complemento = complementotxt.Text;
                end = endereco.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = CEPMasked.Text.ToString();
                endereco = CEP.BuscarCEP(cep);
                PreencherCampos(endereco);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
