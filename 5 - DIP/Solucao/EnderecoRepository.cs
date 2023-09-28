using Entendimento.SOLID._5___DIP.Solucao.Interfaces;

namespace Entendimento.SOLID._5___DIP.Solucao
{
    internal class EnderecoRepository : IEnderecoRepository
    {
        private readonly IConexaoDB _conexao;

        public EnderecoRepository(IConexaoDB Conexao)
        {
            _conexao = Conexao;
        }

        public string IniciarConexao() {
            return _conexao.Conectar();
        }
    }
}
