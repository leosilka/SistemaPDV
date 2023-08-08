namespace SistemaPDV.Menus;

internal class MenuVendedor : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Vendedor");
        Console.WriteLine($"Sistema de vendedores em desenvolvimento!\n");
        Console.WriteLine($"Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
