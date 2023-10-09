using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entendimento.SOLID.SRP.Violacao
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public string Register()
        {
            if (!ValidateEmail(Email))
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

            SendEmail(Email);

            return "Usuário criado com Sucesso!";
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public string SendEmail(string email)
        {
            return $"Email enviado para {email}!";
        }
    }
}
