namespace Entendimento.SOLID.SRP.Solucao
{
    internal class EmailService
    {
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string email)
        {
            Console.WriteLine($"Email enviado para {email}!");
        }
    }
}
