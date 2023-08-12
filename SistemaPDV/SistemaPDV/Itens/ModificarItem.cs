using SistemaPDV.Menus;

namespace SistemaPDV.Itens;

internal class ModificarItem
{
    internal static void AlterarItem(Dictionary<int, DadosItem> itens)
    {
        MenuPrincipal titulo = new MenuPrincipal();
        titulo.Executar();
        titulo.ExibirTituloOpcoes("Modificar Item");
        Console.Write("Digite o codigo do item que deseja realizar alteracao: ");
        int codigoItem = int.Parse(Console.ReadLine()!);

        if (itens.TryGetValue(codigoItem, out DadosItem item))
        {
            bool continuar = true;

            Console.WriteLine($"Item encontrado [{item.NomeItem}]");

            while (continuar)
            {
                Console.WriteLine(@"Escolha uma das opcoes:

[1] - Alterar Nome
[2] - Alterar Preco
[3] - Alterar Estoque
[0] - Sair");
                Console.Write("Qual opcao deseja: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome atual do item: ");
                        string novoNome = Console.ReadLine()!;
                        item.NomeItem = novoNome;
                        break;

                    case 2:
                        Console.Write("Preco atual do item: ");
                        float novoPreco = float.Parse(Console.ReadLine()!);
                        item.PrecoItem = novoPreco;
                        break;

                    case 3:
                        Console.Write("Informe a quantidade de mudanca para o estoque\n" +
                            $"Estoque atual deste item e de [{item.EstoqueItem}]\n" +
                            $"(Caso deseja retirar a quantidade coloque o sinal (-) na frente do valor): ");
                        int novoEstoque = int.Parse(Console.ReadLine()!);
                        item.EstoqueItem += (novoEstoque);
                        break;

                    case 0: break;

                    default: Console.WriteLine("Opcao Invalida!"); break;
                }
                Console.Write("Deseja continuar? [S/N]: ");
                string resposta = Console.ReadLine()!.ToUpper();
                if (resposta == "S")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
        }
        else
        {
            Console.WriteLine("Codigo do item nao encontrado!");
        }

    }
}

