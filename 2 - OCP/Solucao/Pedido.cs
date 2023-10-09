namespace Entendimento.SOLID._2___LSP.Solucao
{
    public class Pedido
    {
        public string Entregar(IFinalizacao finalizacao)
        {
            return finalizacao.Finalizar();
        }
    }
}
