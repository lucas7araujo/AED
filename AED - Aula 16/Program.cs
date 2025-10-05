using System;
using System.Net;
using System.Net.Mail;

namespace EnviarEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // remetente
                string remetenteEmail = "lucasgaraujo.dev@gmail.com";
                string appKey = "vmua dtsb lxtw hdis"; // app password do Gmail

                // destinatário
                string destinatario = "danton.diniz@gmail.com";

                // configuração da mensagem
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(remetenteEmail);
                mail.To.Add(destinatario);
                mail.Subject = "Teste de envio SMTP em C#";
                mail.Body = "Olá, este é um teste de envio de e-mail via SMTP (C#).";

                // configuração do cliente SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remetenteEmail, appKey);
                smtp.EnableSsl = true;

                for (int i = 0; i < 1; i++)
                {
                    
                smtp.Send(mail);
                }

                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
            }
        }
    }
}
