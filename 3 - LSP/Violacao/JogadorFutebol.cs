using System;

namespace Entendimento.SOLID._3___PSL.Violacao
{
    internal class JogadorFutebol : JogadorVoley
    {
        public string Nome { get; private set; }
        public string Especializacao { get; private set; }
        public string Funcao { get; private set; }

        public JogadorFutebol(string nome, string especializacao, string funcao) : base(nome, especializacao, funcao)
        {
            Nome = nome;
            Especializacao = especializacao;
            Funcao = funcao;
        }

        public void Sacar()
        {
            // Não faz nada pois um jogador de futebol não pode sacar a bola
        }

        public void UsarMao()
        {
            if (Funcao != "Goleiro")
                throw new Exception();
        }
    }
}
