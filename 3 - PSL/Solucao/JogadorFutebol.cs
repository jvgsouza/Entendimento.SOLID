namespace Entendimento.SOLID._3___PSL.Solucao
{
    internal class JogadorFutebol : Atleta
    {
        public string Nome { get; private set; }
        public string Especializacao { get; private set; }
        
        public JogadorFutebol(string nome, string especializacao) :  base(nome, especializacao)
        {
            Nome = nome;
            Especializacao = especializacao;
        }
    }
}
