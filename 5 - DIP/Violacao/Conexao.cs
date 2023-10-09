namespace Entendimento.SOLID._5___DIP.Violacao
{
    public class Conexao
    {
        private readonly MySQL _conexao;

        public Conexao()
        {
            _conexao = new MySQL();
        }
    }
}
