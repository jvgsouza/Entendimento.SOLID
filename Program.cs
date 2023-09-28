using Entendimento.SOLID._2___LSP.Solucao;
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
                Console.WriteLine("// Sobre qual princípio gostaria de aprender?                                        //");
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
                        break;
                    case "2":
                        var finalizacaoEntrega = new FinalizacaoEntrega();
                        var pedidoEntrega = new Pedido();
                        Console.WriteLine(pedidoEntrega.Entregar(finalizacaoEntrega));

                        var finalizacaoRetirada = new FinalizacaoRetirada();
                        var pedidoRetirada = new Pedido();
                        Console.WriteLine(pedidoRetirada.Entregar(finalizacaoRetirada));
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
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