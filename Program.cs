using Entendimento.SOLID._2___LSP.Solucao;
using Entendimento.SOLID._3___PSL.Solucao;
using Entendimento.SOLID._4___ISP.Solucao;
using Entendimento.SOLID._5___DIP.Solucao;
using Entendimento.SOLID.SRP.Solucao;

namespace Entendimento.SOLID // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            while (running == true)
            {
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("// Sobre qual princípio gostaria de ver exemplo?                                        //");
                Console.WriteLine("// 1 - S — Single Responsiblity Principle (Princípio da responsabilidade única)      //");
                Console.WriteLine("// 2 - O — Open-Closed Principle (Princípio Aberto-Fechado)                          //");
                Console.WriteLine("// 3 - L — Liskov Substitution Principle (Princípio da substituição de Liskov)       //");
                Console.WriteLine("// 4 - I — Interface Segregation Principle (Princípio da Segregação da Interface)    //");
                Console.WriteLine("// 5 - D — Dependency Inversion Principle (Princípio da inversão da dependência)     //");
                Console.WriteLine("// 6 - Sair                                                                          //");
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var usuarioService = new UsuarioService();
                        var usuario = new Usuario();
                        usuario.Email = "email@email.com";
                        usuario.Nome = "Teste";
                        usuario.Senha = "123456";

                        Console.WriteLine(usuarioService.Register(usuario));
                        Console.WriteLine();
                        break;
                    case "2":
                        var finalizacaoEntrega = new FinalizacaoEntrega();
                        var pedidoEntrega = new Pedido();
                        Console.WriteLine(pedidoEntrega.Entregar(finalizacaoEntrega));
                        Console.WriteLine();

                        var finalizacaoRetirada = new FinalizacaoRetirada();
                        var pedidoRetirada = new Pedido();
                        Console.WriteLine(pedidoRetirada.Entregar(finalizacaoRetirada));
                        Console.WriteLine();
                        break;
                    case "3":
                        var atleta = new Atleta("João", "Vôlei");
                        var sobreAtleta = new Sobre();
                        Console.WriteLine(sobreAtleta.Descricao(atleta));
                        Console.WriteLine();

                        var jogadorFutebol = new JogadorFutebol("Victor", "Futebol");
                        var sobreJogadorFutebol = new Sobre();
                        Console.WriteLine(sobreJogadorFutebol.Descricao(jogadorFutebol));
                        Console.WriteLine();
                        break;
                    case "4":
                        var clt = new CLT();
                        Console.WriteLine(clt.Inserir());
                        Console.WriteLine();

                        var pj = new PJ();
                        Console.WriteLine(pj.Inserir());
                        Console.WriteLine(pj.EmitirNota());
                        Console.WriteLine();
                        break;
                    case "5":
                        var mysql = new ConexaoMySQL();
                        var enderecoMySQL = new EnderecoRepository(mysql);
                        Console.WriteLine(enderecoMySQL.IniciarConexao());
                        Console.WriteLine();

                        var sql = new ConexaoSQL();
                        var enderecoSQL = new EnderecoRepository(sql);
                        Console.WriteLine(enderecoSQL.IniciarConexao());
                        Console.WriteLine();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("Selecione um exemplo válido!");
                        Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");
                        break;
                }
            }
        }
    }
}