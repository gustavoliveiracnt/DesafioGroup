using System;
using System.Net;
using System.Net.Mail;

namespace Desafio_Group.Funcionalidades
{
    internal class Email
    {
        #region MÉTODOS

        public string EnviarEmail(string emailRemetente, ref string tokenCode)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("groupsoftcad@outlook.com", "group!123");
                    smtp.EnableSsl = true;

                    using (MailMessage email = new MailMessage())
                    {
                        Random token = new Random();
                         tokenCode = token.Next(100000, 1000000).ToString("D6");

                        email.From = new MailAddress(emailRemetente);
                        email.To.Add("groupsoftcad@outlook.com");

                        email.Subject = "Código Para Redefinir Senha";
                        email.IsBodyHtml = false;
                        email.Body = $"Seu código para redefinição: {tokenCode}";

                        smtp.Send(email);
                    }
                }
                throw new Exception($"Token enviado para o e-mail {emailRemetente}. Favor verificar sua caixa de entrada.");
                //MessageBox.Show(, "E-mail enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                throw new Exception($"Ocorreu um erro ao enviar e-mail:" + ex.Message);
                //MessageBox.Show(", "Erro ao enviar e-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
               //MessageBox.Show(, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
