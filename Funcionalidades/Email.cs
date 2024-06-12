using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group.Funcionalidades
{
    internal class Email
    {
        public string EnviarEmail(string emailRemetente)
        {
            string tokenCode;
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
                MessageBox.Show($"Token enviado para o e-mail {emailRemetente}. Favor verificar sua caixa de entrada.", "E-mail enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return tokenCode;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Ocorreu um erro ao enviar e-mail: " + ex.Message, "Erro ao enviar e-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return string.Empty;
        }
    }
}
