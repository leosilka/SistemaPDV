using SistemaPDV.Cadastros;
using SistemaPDV.Menus;
using SistemaPDV.Modelos;

Dictionary<string, Usuarios> usuarios = new Dictionary<string, Usuarios>();

Dictionary<int, MenuPrincipal> opcoes = new();
opcoes.Add(1, new MenuUsuarios(usuarios));
opcoes.Add(2, new MenuVendedor());
opcoes.Add(3, new MenuItem());
opcoes.Add(4, new MenuCaixa());
opcoes.Add(5, new MenuPedido());
opcoes.Add(0, new MenuSair());

Logos logos = new Logos();
logos.ExibirLogoInicial();

void ExibirOpcoes()
{
    Console.WriteLine(@"
---------------------------
    SISTEMA PDV - v1
---------------------------

[1] - Menu usuário
[2] - Menu vendedor
[3] - Menu item
[4] - Menu caixa
[5] - Menu pedido
[0] - Sair do sistema
");
    Console.Write("\nDigite a sua opcao: ");
    string respostaOpcao = Console.ReadLine()!;
    int respostaOpcaoNumerica = int.Parse(respostaOpcao);

    if (opcoes.ContainsKey(respostaOpcaoNumerica))
    {
        MenuPrincipal menuExibido = opcoes[respostaOpcaoNumerica];
        menuExibido.Executar();
        if (respostaOpcaoNumerica > 0) ExibirOpcoes();
    } else
    {
        Console.WriteLine("Opcao invalida!");
        ExibirOpcoes();
    }
}

ExibirOpcoes();