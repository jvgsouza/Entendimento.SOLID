namespace Entendimento.SOLID._3___LSP.Violacao
{
    public class JogadorFutebol : JogadorVoley
    {
        public new string Nome { get; private set; }
        public new string Especializacao { get; private set; }
        public new string Funcao { get; private set; }

        public JogadorFutebol(string nome, string especializacao, string funcao) : base(nome, especializacao, funcao)
        {
            Nome = nome;
            Especializacao = especializacao;
            Funcao = funcao;
        }

        public static new void Sacar()
        {
            // Não faz nada pois um jogador de futebol não pode sacar a bola
        }

        public new void UsarMao()
        {
            if (Funcao != "Goleiro")
                throw new Exception();
        }
    }
}
