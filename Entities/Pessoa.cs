using System.Collections.Generic;

namespace Desafio_Group.Entities
{
    internal class Pessoa
    {
        #region ATRIBUTOS
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }
        #endregion

        #region CONSTRUTORES
        public Pessoa(List<string> dados)
        {
            this.Nome = dados[0];
            this.Documento = dados[1];
            this.Telefone = dados[2];
            this.Email = dados[3];
            this.Endereco = dados[4];
        }

        public Pessoa()
        {

        }
        #endregion


    }
}
