namespace Entendimento.SOLID._5___DIP.Violacao
{
    internal class Conexao
    {
        private readonly MySQL _conexao;

        public Conexao()
        {
            _conexao = new MySQL();
        }
    }
}
