namespace Entendimento.SOLID.SRP.Solucao
{
    public class EmailService
    {
        public bool ValidarEmail(string email)
        {
            return email.Contains('@');
        }

        public void EnviarEmail(string email)
        {
            Console.WriteLine($"Email enviado para {email}!");
        }
    }
}
