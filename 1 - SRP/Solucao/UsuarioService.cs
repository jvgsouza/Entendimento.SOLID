using System.ComponentModel.DataAnnotations;

namespace Entendimento.SOLID.SRP.Solucao
{
    public class UsuarioService
    {
        public string Registrar(Usuario usuario)
        {
            var emailService = new EmailService();
            if (!emailService.ValidarEmail(usuario.Email))
                throw new ValidationException("Email inválido!");

            var usuarioRepository = new UsuarioRepository();
            usuarioRepository.Registrar(usuario);
            emailService.EnviarEmail(usuario.Email);

            return "Usuário salvo com sucesso!";
        }
    }
}
