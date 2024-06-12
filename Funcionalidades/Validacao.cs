using Desafio_Group.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_Group.Validacoes
{
    internal class Validacao
    {
        public bool validarEmail(string email)
        {

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool validarCEP(string cep)
        {
            var regex = new Regex(@"^\d{8}");
            return regex.IsMatch(cep);
        }
        public bool validarCNPJ(string cnpj)
        {
            int[] multip1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multip2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("/", "").Replace("-", "");

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

        public bool validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (cpf == new string(j.ToString()[0], 11))
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public bool verificarLogin(string login, string senha)
        {
            BancoDados dbvalidar = new BancoDados();
            if(dbvalidar.VerificarLoginBanco(login, senha))
            {
                return true;
            }
            return false;
        }
    }
}
