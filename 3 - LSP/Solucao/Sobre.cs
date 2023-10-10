namespace Entendimento.SOLID._3___LSP.Solucao
{
    public class Sobre
    {
        public string Descricao(Atleta atleta)
        {
            return "Meu nome é " + atleta.Nome + " e pratico " + atleta.Especializacao;
        }
    }
}
