using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Group.Validacoes
{
    internal class Validacao
    {

        public bool validarCNPJ(string cnpj)
        {
            int[] multip1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multip2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int somador, resto;

            string digito, cnpjAux;


            if (cnpj.Length != 14)
                return false;
            else
            {
                cnpjAux = cnpj.Substring(0, 12);
                somador = 0;
                for (int i = 0; i < 12; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multip1[i];
                }
                resto = somador % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                cnpjAux = cnpjAux + digito;

                somador = 0;

                for (int i = 0; i < 13; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multip2[i];
                }

                resto = somador % 11; 
                
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
        }
    }
}
