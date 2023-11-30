using System;

namespace Atividade
{
    public class Menu
    {
        private static readonly string OpcaoSaida = "saida";
        private static readonly string OpcaoEntrada = "entrada";
        private static readonly string OpcaoVoltar = "voltar";

        public static void Principal(Estoque estoque)
        {
            bool sair = false;

            while (!sair)
            {
                MostrarMenuPrincipal();
                string escolha = Console.ReadLine();
                Console.WriteLine();

                switch (escolha)
                {
                    case "1":
                        GerenciarCadastro(estoque);
                        break;
                    case "2":
                        GerenciarConsulta(estoque);
                        break;
                    case "3":
                        estoque.AtualizarSaldo();
                        break;
                    case "4":
                        estoque.ObterTodos();
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        MenuRelatorios(estoque);
                        break;
                    case "0":
                        Console.WriteLine("Aplicação encerrada...");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void GerenciarCadastro(Estoque estoque)
        {
            do
            {
                estoque.CadastrarProduto();
                Console.WriteLine("\nDeseja cadastrar outro produto? (S/N)");
            } while (Console.ReadLine()?.ToUpper() == "S");
        }

        private static void GerenciarConsulta(Estoque estoque)
        {
            estoque.BuscarProduto();
            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private static void MenuRelatorios(Estoque estoque)
        {
            bool sair = false;

            while (!sair)
            {
                MostrarMenuRelatorios();
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        estoque.ListaProdutoSaldo();
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        estoque.ListaProdutoValor();
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        estoque.ListaValorEstoque();
                        Console.Write("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void MostrarMenuPrincipal()
        {
            Console.WriteLine("\n------- CONTROLE DE ESTOQUE -------");
            Console.WriteLine("1 - CADASTRAR PRODUTOS");
            Console.WriteLine("2 - CONSULTAR PRODUTO");
            Console.WriteLine("3 - ATUALIZAR ESTOQUE");
            Console.WriteLine("4 - LISTAR PRODUTOS");
            Console.WriteLine("5 - GERAR RELATÓRIO");
            Console.WriteLine("0 - SAIR");
            Console.Write("Escolha uma opção: ");
        }

        private static void MostrarMenuRelatorios()
        {
            Console.WriteLine("\n------- RELATÓRIOS -------");
            Console.WriteLine("1 - LISTA DE PRODUTOS POR LIMITE DE SALDO");
            Console.WriteLine("2 - LISTA DE PRODUTOS POR INTERVALO DE VALOR [R$]");
            Console.WriteLine("3 - VALOR TOTAL DE ESTOQUE");
            Console.WriteLine("0 - VOLTAR");
            Console.Write("Escolha uma opção: ");
        }
    }
}
