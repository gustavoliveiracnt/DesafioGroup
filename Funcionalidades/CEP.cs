using Desafio_Group.Validacoes;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Desafio_Group.Funcionalidades
{
    public class CEP
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public CEP(){ }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Unidade { get; set; }
        public string Ibge { get; set; }

        public string BuscarCEP(string cep)
        {
            try
            {
                Validacao validar = new Validacao();

                if (validar.validarCEP(cep))
                {
                    HttpResponseMessage httpResponse = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string jsonResponse = httpResponse.Content.ReadAsStringAsync().Result;
                        dynamic dados = JsonConvert.DeserializeObject(jsonResponse);

                        if (dados.erro != null)
                        {
                            MessageBox.Show("CEP não encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return string.Empty;
                        }

                        Logradouro = dados.logradouro;
                        Bairro = dados.bairro;
                        Localidade = dados.localidade;
                        Uf = dados.uf;
                        Cep = dados.cep;

                        return $"{Logradouro} - {Bairro}, {Localidade} - {Uf} ({Cep})";
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao consultar CEP: {httpResponse.StatusCode}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("CEP inválido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao consultar CEP: " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
    }
}
