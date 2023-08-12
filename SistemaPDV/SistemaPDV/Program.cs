using SistemaPDV.Menus;

Logos logo = new Logos();
logo.ExibirLogoInicial();

Dictionary<int, MenuPrincipal> opcoes = new Dictionary<int, MenuPrincipal>();
opcoes.Add(1, new MenuCliente());
opcoes.Add(2, new MenuItem());
//opcoes.Add(3, new MenuPedido());
//opcoes.Add(4, new MenuCaixa());
opcoes.Add(0, new MenuSair());

void ExibirOpcoes()
{
    Console.WriteLine(@"
---------------------------
    SISTEMA PDV - v1.1
---------------------------

[1] - Menu Cliente
[2] - Menu Item
[3] - Menu Caixa
[4] - Menu Pedido
[0] - Sair
");
    Console.Write("\nDigite a sua opcao: ");
    string respostaOpcao = Console.ReadLine()!;
    int respostaOpcaoNumerica = int.Parse(respostaOpcao);

    if (opcoes.ContainsKey(respostaOpcaoNumerica))
    {
        MenuPrincipal menuExibido = opcoes[respostaOpcaoNumerica];
        menuExibido.Executar();
        if (respostaOpcaoNumerica > 0) ExibirOpcoes();
    }
    else
    {
        Console.WriteLine("Opcao invalida!");
        ExibirOpcoes();
    }
}

ExibirOpcoes();