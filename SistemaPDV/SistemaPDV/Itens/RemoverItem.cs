using SistemaPDV.Menus;

namespace SistemaPDV.Itens;

internal class RemoverItem
{
    internal static void ExcluirItem(Dictionary<int, DadosItem> itens)
    {
        MenuPrincipal titulo = new MenuPrincipal();
        titulo.Executar();
        titulo.ExibirTituloOpcoes("Excluir Item");
        Console.Write("Digite o codigo do item que deseja excluir: ");
        int item = int.Parse(Console.ReadLine()!);

        if (itens.TryGetValue(item, out DadosItem dadosItem))
        {
            Console.WriteLine($"Item encontrado [{dadosItem.NomeItem}]");
            Console.Write("Deseja realmente excluir o item? [S/N]: ");
            string resposta = Console.ReadLine()!.ToUpper();

            if (resposta == "S")
            {
                Console.WriteLine($"Item [{dadosItem.NomeItem}] excluido com sucesso!");
                itens.Remove(item);
            }

        }
        else
        {
            Console.WriteLine("Codigo de item nao encontrado!");
        }
        Console.WriteLine("Digite qualquer tecla para voltar!");
        Console.ReadKey();
    }
}
