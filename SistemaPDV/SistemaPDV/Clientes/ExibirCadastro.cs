namespace SistemaPDV.Clientes;

public class ExibirCadastro
{
    public static void CadastrosCliente(Dictionary<string, DadosCliente> cliente)
    {
        Console.WriteLine(@"Escolha uma das opcoes abaixo:

[1] - Buscar Todos os Clientes
[2] - Buscar por CPF
[3] - Buscar por Codigo
[0] - Voltar");
        Console.Write("Qual das opcoes deseja: ");

        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                ListarClientes(cliente);
                break;

            case 2:
                Console.Write("Digite o CPF para pesquisa: ");
                string cpfPesquisa = Console.ReadLine()!;
                ListarPorCpf(cliente, cpfPesquisa);
                break;

            case 3:
                Console.Write("Digite o codigo para pesquisa: ");
                int codigoPesquisa = int.Parse(Console.ReadLine()!);
                ListarPorCodigo(cliente, codigoPesquisa);
                break;

            case 0:
                break;

            default:
                Console.WriteLine("Opcao Invalida!");
                break;
        }
    }

    private static void ListarClientes(Dictionary<string, DadosCliente> cliente)
    {
        Console.WriteLine("Lista de todos os Clientes:");
        foreach (var clientes in cliente.Values)
        {
            Console.WriteLine($"\n====================" +
            $"\nCodigo: {clientes.CodigoCliente}" +
            $"\nNome: {clientes.Nome}" +
            $"\nCPF: {clientes.Cpf}" +
            $"\nE-mail: {clientes.Email}" +
            $"\nTelefone: {clientes.Telefone}" +
            $"\nData de Nascimento: {clientes.DataNascimento.ToString("dd/MM/yyyy")}");
        }
    }
    private static void ListarPorCpf(Dictionary<string, DadosCliente> cliente, string cpfPesquisa)
    {
        var clienteEncontrado = cliente.Values.FirstOrDefault(dados => dados.Cpf.Equals(cpfPesquisa));
        if (clienteEncontrado != null)
        {
            ExibirDadosCliente(clienteEncontrado);
        }
        else
        {
            Console.WriteLine($"\nCliente nao encontrado pelo CPF informado!");
        }
    }

    private static void ExibirDadosCliente(DadosCliente clienteEncontrado)
    {
        Console.WriteLine($"\n====================" +
            $"\nCodigo: {clienteEncontrado.CodigoCliente}" +
            $"\nNome: {clienteEncontrado.Nome}" +
            $"\nCPF: {clienteEncontrado.Cpf}" +
            $"\nE-mail: {clienteEncontrado.Email}" +
            $"\nTelefone: {clienteEncontrado.Telefone}" +
            $"\nData de Nascimento: {clienteEncontrado.DataNascimento.ToString("dd/MM/yyyy")}");
    }

    private static void ListarPorCodigo(Dictionary<string, DadosCliente> cliente, int codigoPesquisa)
    {
        var clienteEncontrado = cliente.Values.FirstOrDefault(dados => dados.CodigoCliente.Equals(codigoPesquisa));
        if (clienteEncontrado != null)
        {
            ExibirDadosCliente(clienteEncontrado);
        }
        else
        {
            Console.WriteLine($"\nCliente nao encontrado pelo CODIGO informado!");
        }
    }
}
