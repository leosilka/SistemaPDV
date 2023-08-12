using SistemaPDV.Itens;

namespace SistemaPDV.Menus;

internal class MenuItem : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Cliente");
        Console.WriteLine(@"
[1] - Cadastrar Item
[2] - Exibir Itens
[3] - Modificar Cadastro de Item
[4] - Remover Cadastro de Item
[0] - Voltar
");
        Console.Write("Escolha a opcao desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                CadastrarItem.AdicionarItem();
                break;

            case 2:
                ExibirItem.ItensCadastrados(CadastrarItem.itens);
                break;

            case 3:
                ModificarItem.AlterarItem(CadastrarItem.itens);
                break;

            case 4:
                RemoverItem.ExcluirItem(CadastrarItem.itens);
                break;

            case 0:
                break;

            default: Console.WriteLine("Opcao Invalida!"); break;
        }
        Logos tela = new Logos();
        tela.TelaDeCarregamento();
        Console.Clear();
    }

}
