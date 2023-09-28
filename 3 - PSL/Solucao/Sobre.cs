namespace Entendimento.SOLID._3___PSL.Solucao
{
    internal class Sobre
    {
        public string Descricao(Atleta atleta)
        {
            return "Meu nome é " + atleta.Nome + " e pratico " + atleta.Especializacao;
        }
    }
}
