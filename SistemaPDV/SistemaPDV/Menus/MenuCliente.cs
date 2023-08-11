using SistemaPDV.Clientes;

namespace SistemaPDV.Menus;

public class MenuCliente : MenuPrincipal
{
    public override void Executar()
    {
        base.Executar();
        ExibirTituloOpcoes("Menu Cliente");
        Console.WriteLine(@"
[1] - Cadastrar Cliente
[2] - Exibir Cadastro
[3] - Modificar Cadastro
[4] - Remover Cadastro
[0] - Voltar
");
        Console.Write("Escolha a opcao desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                CadastrarCliente.AdicionarCliente();
                break;

            case 2:
                ExibirCadastro.CadastrosCliente(CadastrarCliente.cliente);
                break;

            case 3:
                ModificarCadastroCliente.ModificarCliente(CadastrarCliente.cliente);
                break;

            case 4:
                RemoverClientes.RemoverCliente(CadastrarCliente.cliente);
                break;

            case 0:
                break;

            default:
                Console.WriteLine("Opcao Invalida!");
                break;
        }

        Console.WriteLine($"\nDigite alguma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
