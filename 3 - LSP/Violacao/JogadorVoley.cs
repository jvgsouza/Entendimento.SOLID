namespace Entendimento.SOLID._3___PSL.Violacao
{
    abstract public class JogadorVoley
    {
        public string Nome { get; private set; }
        public string Especializacao { get; private set; }
        public string Funcao { get; private set; }

        public JogadorVoley(string nome, string especializacao, string funcao)
        {
            Nome = nome;
            Especializacao = especializacao;
            Funcao = funcao;
        }

        public void Sacar()
        { 
            // Saca a bola
        }

        public void UsarMao()
        {
            // Utiliza a mão para fazer uma jogada
        }
    }
}
