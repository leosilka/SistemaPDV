namespace SistemaPDV.Menus;

internal class MenuCaixa : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Caixa");
        Console.WriteLine($"Sistema de caixa em desenvolvimento!\n");
        Console.WriteLine($"Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
