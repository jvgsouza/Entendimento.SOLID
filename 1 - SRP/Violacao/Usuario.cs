using MySql.Data.MySqlClient;
using System.Data;

namespace Entendimento.SOLID.SRP.Violacao
{
    public class Usuario
    {
        public string Email { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public string Registrar()
        {
            if (!ValidarEmail(Email))
                return "Email inválido!";

            using (var conn = new MySqlConnection())
            {
                var cmd = new MySqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Insert into 
                        Usuario 
                            (email, nome, senha) 
                        values 
                            (@email, @nome, @senha)";

                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("senha", Senha);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            EnviarEmail(Email);

            return "Usuário criado com Sucesso!";
        }

        public bool ValidarEmail(string email)
        {
            return email.Contains('@');
        }

        public string EnviarEmail(string email)
        {
            return $"Email enviado para {email}!";
        }
    }
}
