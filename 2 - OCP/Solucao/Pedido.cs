namespace Entendimento.SOLID._2___OCP.Solucao
{
    public class Pedido
    {
        public string Entregar(IFinalizacao finalizacao)
        {
            return finalizacao.Finalizar();
        }
    }
}
