namespace Desafio_Group.Entities
{
    public class Endereco
    {
        #region ATRIBUTOS
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        #endregion

        #region CONSTRUTORES
        public Endereco() { }

        public Endereco(string logradouro, string complemento, string numero, string bairro, string localidade, string uF, string cep)
        {
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.UF = uF;
            this.Cep = cep;
        }
        #endregion

        #region MÉTODO

        public override string ToString()
        {
            return $"{this.Logradouro}, nº{this.Numero} - {this.Complemento} - {this.Bairro}, {this.Localidade}/{this.UF} ({this.Cep})";
        }
        #endregion
    }
}
