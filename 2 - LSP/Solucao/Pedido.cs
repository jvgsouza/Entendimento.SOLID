namespace Entendimento.SOLID._2___LSP.Solucao
{
    internal class Pedido
    {
        public string Entregar(Finalizacao finalizacao)
        {
            return finalizacao.Finalizar();
        }
    }
}
