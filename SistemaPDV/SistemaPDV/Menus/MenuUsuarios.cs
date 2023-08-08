using SistemaPDV.Cadastros;
using SistemaPDV.Modelos;

namespace SistemaPDV.Menus;

internal class MenuUsuarios : MenuPrincipal
{
    private CadastroUsuarios? CadastroUsuarios;
    
    public MenuUsuarios(Dictionary<string, Usuarios> usuarios)
    {
        CadastroUsuarios = new CadastroUsuarios(usuarios);
    }

    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Usuarios");
        Console.WriteLine(@"
[1] - Adicionar usuario
[2] - Exibir usuarios
[3] - Modificar usuario
[4] - Remover usuario
[5] - Voltar
");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                CadastroUsuarios?.AdicionarUsuario();
                break;

            case 2:
                CadastroUsuarios?.ConsultarUsuario();
                break;

            case 3:
                CadastroUsuarios?.ModificarUsuario();
                break;

            case 4:
                CadastroUsuarios?.RemoverUsuario();
                break;
            case 5:
                break;

            default:
                Console.WriteLine("Opcao Invalida!");
                break;
        }

        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
