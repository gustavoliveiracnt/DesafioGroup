using System.Security.Cryptography;
using System.Text;

namespace Desafio_Group.Funcionalidades
{
    public class Hash
    {
        #region ATRIBUTOS
        private HashAlgorithm _algoritmo;
        #endregion

        #region CONSTRUTORES
        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }
        #endregion

        #region MÉTODOS
        public string Criptografar(string senha)
        {
            using (_algoritmo)
            {
                byte[] bytes = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        #endregion
    }
}
