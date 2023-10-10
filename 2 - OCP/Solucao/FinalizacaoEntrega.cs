namespace Entendimento.SOLID._2___OCP.Solucao
{
    public class FinalizacaoEntrega : IFinalizacao
    {
        public string Finalizar()
        {
            return "Pedido enviado ao endereço do comprador!";
        }
    }
}
