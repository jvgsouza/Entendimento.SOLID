namespace Entendimento.SOLID._3___LSP.Solucao
{
    public class Atleta
    {
        public Atleta(string nome, string especializacao) {
            Nome = nome;
            Especializacao = especializacao;
        }

        public string Nome { get; private set; }
        public string Especializacao { get; private set; }
    }
}
