using Entendimento.SOLID._5___DIP.Solucao.Interfaces;

namespace Entendimento.SOLID._5___DIP.Solucao
{
    internal class ConexaoSQL : IConexaoDB
    {
        public string Conectar()
        {
            return "Concetado ao SQL Server";
        }
    }
}
