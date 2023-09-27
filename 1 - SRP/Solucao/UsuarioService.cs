using System.ComponentModel.DataAnnotations;

namespace Entendimento.SOLID.SRP.Solucao
{
    internal class UsuarioService
    {
        public string Register(Usuario usuario)
        {
            var emailService = new EmailService();
            if (!emailService.ValidateEmail(usuario.Email))
                throw new ValidationException("Email inválido!");

            var usuarioRepository = new UsuarioRepository();
            usuarioRepository.Register(usuario);
            emailService.SendEmail(usuario.Email);

            return "Usuário salvo com sucesso!";
        }
    }
}
