using Desafio_Group.Entities;
using Desafio_Group.Validacoes;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Desafio_Group.Funcionalidades
{
    public static class CEP
    {
        #region ATRIBUTOS
        private static readonly HttpClient httpClient = new HttpClient();
        #endregion

        #region PROPRIEDADES
        public static string Cep { get; set; }
        public static string Logradouro { get; set; }
        public static string Complemento { get; set; }
        public static string Bairro { get; set; }
        public static string Localidade { get; set; }
        public static string Uf { get; set; }
        public static string Unidade { get; set; }
        public static string Ibge { get; set; }

        #endregion

        #region MÉTODOS
        public static Endereco BuscarCEP(string cep)
        {
            try
            {

                if (Validacao.validarCEP(cep))
                {
                    HttpResponseMessage httpResponse = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string jsonResponse = httpResponse.Content.ReadAsStringAsync().Result;
                        dynamic dados = JsonConvert.DeserializeObject(jsonResponse);

                        if (dados.erro != null)
                        {
                            throw new Exception("CEP não encontrado.");
                        }

                        Endereco endereco = new Endereco();
                        endereco.Logradouro = Logradouro = dados.logradouro;
                        endereco.Bairro = Bairro = dados.bairro;
                        endereco.Localidade = Localidade = dados.localidade;
                        endereco.UF = Uf = dados.uf;
                        endereco.Cep = cep;
                        Cep = dados.cep;

                        return endereco;
                    }
                    else
                    {
                        throw new Exception($"Erro ao consultar CEP: {httpResponse.StatusCode}");
                        //MessageBox.Show(, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception("CEP inválido.");
                    //MessageBox.Show(, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao consultar CEP: " + e.Message);
                //MessageBox.Show(, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
