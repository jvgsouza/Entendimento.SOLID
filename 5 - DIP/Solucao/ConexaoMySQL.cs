using Entendimento.SOLID._5___DIP.Solucao.Interfaces;

namespace Entendimento.SOLID._5___DIP.Solucao
{
    public class ConexaoMySQL : IConexaoDB
    {
        public string Conectar()
        {
            return "Concetado ao MySQL";
        }
    }
}
