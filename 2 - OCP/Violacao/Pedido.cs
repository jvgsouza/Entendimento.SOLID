namespace Entendimento.SOLID._2___LSP.Violacao
{
    public class Pedido
    {
        public void Finalizar(TipoFinalizacao tipoFinalizacao)
        {
            if(tipoFinalizacao == TipoFinalizacao.Retirada)
            {
                // Deixa pedido disponível para retirada
            }

            if (tipoFinalizacao == TipoFinalizacao.Entrega)
            {
                // Envia o pedido ao endereço do comprador
            }
        }
    }
}
