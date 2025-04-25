using System.Net;
using System.Net.Mail;
using Portfolio.Models;

namespace Portfolio.Services;

public interface IServicioEmail
{
    Task Enviar(ContactoViewModel contacto);
}

public class ServicioEmailGmail : IServicioEmail
{
    private readonly IConfiguration _configuration;

    public ServicioEmailGmail(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task Enviar(ContactoViewModel contacto)
    {
        var emailEmisor = _configuration["CONFIGURACIONES_EMAIL:EMAIL"];
        var password = _configuration["CONFIGURACIONES_EMAIL:PASSWORD"];
        var host = _configuration["CONFIGURACIONES_EMAIL:HOST"];
        var port = int.Parse(_configuration["CONFIGURACIONES_EMAIL:PORT"]!);

        
        var smtpCliente = new SmtpClient(host, port);
        smtpCliente.EnableSsl = true;
        smtpCliente.UseDefaultCredentials = false;

        smtpCliente.Credentials = new NetworkCredential(emailEmisor, password);
        var mensaje = new MailMessage(emailEmisor, emailEmisor,
            $"El cliente {contacto.Nombre} ({contacto.Email}) quiere contactarte", contacto.Mensaje);
        
        await smtpCliente.SendMailAsync(mensaje);
    }
}