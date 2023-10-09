using Entendimento.SOLID._4___ISP.Solucao.Interfaces;

namespace Entendimento.SOLID._4___ISP.Solucao
{
    public class PJ : IPJ
    {
        public string Inserir()
        {
            return "Contrato PJ inserido com sucesso!";
        }

        public string EmitirNota()
        {
            return "Nota emitida com sucesso!";
        }
    }
}
