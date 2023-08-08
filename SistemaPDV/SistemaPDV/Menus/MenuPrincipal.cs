namespace SistemaPDV.Menus;

internal class MenuPrincipal
{
    public void ExibirTituloOpcoes(string opcoes)
    {
        int quantidadeLetras = opcoes.Length;
        string caracterEspecial = string.Empty.PadLeft(quantidadeLetras, '-');
        Console.WriteLine(caracterEspecial);
        Console.WriteLine(opcoes);
        Console.WriteLine(caracterEspecial + "\n");
    }

    public virtual void Executar()
    {
        Console.Clear();
    }
}
