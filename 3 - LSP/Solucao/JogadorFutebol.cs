namespace Entendimento.SOLID._3___LSP.Solucao
{
    public class JogadorFutebol : Atleta
    {
        public new string Nome { get; private set; }
        public new string Especializacao { get; private set; }
        
        public JogadorFutebol(string nome, string especializacao) :  base(nome, especializacao)
        {
            Nome = nome;
            Especializacao = especializacao;
        }
    }
}
