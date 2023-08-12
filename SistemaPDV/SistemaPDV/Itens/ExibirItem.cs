using SistemaPDV.Menus;

namespace SistemaPDV.Itens;

internal class ExibirItem
{
    internal static void ItensCadastrados(Dictionary<int, DadosItem> itens)
    {
        Console.Clear();
        MenuPrincipal titulo = new MenuPrincipal();
        titulo.ExibirTituloOpcoes("Exibir Item");
        Console.WriteLine(@"
[1] - Exibir Itens
[2] - Exibir por Codigo
[0] - Voltar");

        Console.Write("Escolha uma das opcoes acima: ");
        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                ListarItens(itens);
                break;

            case 2:
                Console.WriteLine("Digite o codigo do produto: ");
                int codigoPesquisa = int.Parse(Console.ReadLine()!);
                ListarItensCodigo(itens, codigoPesquisa);
                break;

            case 0: break;

            default: Console.WriteLine("Opcao Invalida!"); break;
        }
        Console.WriteLine("\nClique qualquer tecla para voltar ao menu principal!");
        Console.ReadKey();
        Logos tela = new Logos();
        tela.TelaDeCarregamento();
        Console.Clear();
    }

    private static void ListarItensCodigo(Dictionary<int, DadosItem> itens, int codigoPesquisa)
    {
        var itemEncontrado = itens.Values.FirstOrDefault(dados => dados.CodigoItem.Equals(codigoPesquisa));
        if (itemEncontrado != null)
        {
            ExibirItemEncontrado(itemEncontrado);
        }
        else
        {
            Console.WriteLine("Codigo de item nao encontrado!");
        }
    }

    private static void ExibirItemEncontrado(DadosItem itemEncontrado)
    {
        Console.WriteLine(@$"
Codigo: {itemEncontrado.CodigoItem}
Nome: {itemEncontrado.NomeItem}
Preco: R${itemEncontrado.PrecoItem:F2}
Quantidade em Estoque: {itemEncontrado.EstoqueItem}");
    }

    private static void ListarItens(Dictionary<int, DadosItem> itens)
    {
        MenuPrincipal titulo = new MenuPrincipal();
        titulo.ExibirTituloOpcoes("Lista Completa de Itens");
        foreach (var item in itens.Values)
        {
            Console.WriteLine(@$"==============
Codigo: {item.CodigoItem}
Nome: {item.NomeItem}
Preco: R${item.PrecoItem:F2}
Quantidade em Estoque: {item.EstoqueItem}");
        }
    }
}
