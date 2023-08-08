namespace SistemaPDV.Menus;

internal class MenuItem : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Item");
        Console.WriteLine($"Sistema de itens em desenvolvimento!\n");
        Console.WriteLine($"Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
