namespace Entendimento.SOLID.SRP.Solucao
{
    public class EmailService
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string email)
        {
            Console.WriteLine($"Email enviado para {email}!");
        }
    }
}
