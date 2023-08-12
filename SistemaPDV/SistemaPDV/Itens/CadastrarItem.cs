using SistemaPDV.Menus;

namespace SistemaPDV.Itens;

internal class CadastrarItem : MenuPrincipal
{
    public static Dictionary<int, DadosItem> itens = new Dictionary<int, DadosItem>();
    public static int codigoItem = 0;
    public static void AdicionarItem()
    {
        while (true)
        {
            Console.Clear();

            MenuPrincipal titulo = new MenuPrincipal();
            titulo.ExibirTituloOpcoes("Cadastrar Item");

            Console.Write("\nInforme o nome do item: ");
            string nomeItem = Console.ReadLine()!;

            Console.Write("Informe o preco do item: ");
            float precoItem = float.Parse(Console.ReadLine()!);

            Console.Write("Informe a quantidade em estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine()!);

            codigoItem++;

            DadosItem novoItem = new DadosItem(codigoItem, nomeItem, precoItem, quantidadeEstoque);
            itens[codigoItem] = novoItem;

            Console.Write("Deseja cadastrar um novo item? [S/N]: ");
            string resposta = Console.ReadLine()!.ToUpper();

            if (resposta == "S")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        Logos tela = new Logos();
        tela.TelaDeCarregamento();
        Console.Clear();
    }
}
