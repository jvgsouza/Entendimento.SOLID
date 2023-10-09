namespace Entendimento.SOLID._2___LSP.Solucao
{
    internal class Pedido
    {
        public string Entregar(IFinalizacao finalizacao)
        {
            return finalizacao.Finalizar();
        }
    }
}
