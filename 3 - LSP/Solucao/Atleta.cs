namespace Entendimento.SOLID._3___PSL.Solucao
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
