using Entendimento.SOLID._4___ISP.Violacao.Interfaces;

namespace Entendimento.SOLID._4___ISP.Violacao
{
    internal class CLT : IContratoServicos
    {
        public void Inserir()
        {
            // Insere contrato
        }

        public void EmitirNota()
        {
            throw new NotImplementedException("Contrato do tipo CLT não emite nota!");
        }
    }
}
