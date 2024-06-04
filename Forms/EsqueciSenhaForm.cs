using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class EsqueciSenhaForm : Form
    {
        string randomCode;
        public static string to;
        public EsqueciSenhaForm()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviarTokenButton_Click(object sender, EventArgs e)
        {
            string from, pass, mensagem;
            Random random = new Random();
            randomCode = random.Next(999999).ToString();
            MailMessage message = new MailMessage();
            to = recuperacaoEmail.Text.ToString();
            from = "groupsoftwarecad@gmail.com";
            pass = "group!123";
            mensagem = $"Seu código para redefinição: {randomCode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mensagem;
            message.Subject = "Código Para Redefinir Senha";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Código enviado com sucesso.");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            if (randomCode == tokenTxt.ToString())
            {
                RedefinirSenhaForm redefinir = new RedefinirSenhaForm();
                this.Hide();
                redefinir.Show();

            }
            else
            {
                MessageBox.Show("Código incorreto. ");
            }
        }
    }
}
