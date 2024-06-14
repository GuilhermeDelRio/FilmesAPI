using MailKit.Net.Smtp;
using MimeKit;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class EmailService
    {

        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(string[] destinatario, string assunto, int usuarioId, string code)
        {
            Mensagem mensagem = new Mensagem(destinatario, assunto, usuarioId, code);
            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            Enviar(mensagemDeEmail);
        }

        private void Enviar(MimeMessage mensagemDeEmail)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(
                        _configuration.GetValue<string>("EmailSettings:SmtpServer"),
                        _configuration.GetValue<int>("EmailSettings:Port"), true);

                    client.AuthenticationMechanisms.Remove("XOUATH2");

                    client.Authenticate(
                        _configuration.GetValue<string>("EmailSettings:From"),
                        _configuration.GetValue<string>("EmailSettings:Password"));

                    client.Send(mensagemDeEmail);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            };
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem)
        {
            var mensageDeEmail = new MimeMessage();
            mensageDeEmail.From.Add(new MailboxAddress("Teste", _configuration.GetValue<string>("EmailSettings:From")));
            mensageDeEmail.To.AddRange(mensagem.Destinatario);
            mensageDeEmail.Subject = mensagem.Assunto;
            mensageDeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Conteudo
            };

            return mensageDeEmail;
        }
    }
}
