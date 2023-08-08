namespace SistemaPDV.Menus;

internal class MenuPedido : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Pedido");
        Console.WriteLine($"Sistema de peidos em desenvolvimento!\n");
        Console.WriteLine($"Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
