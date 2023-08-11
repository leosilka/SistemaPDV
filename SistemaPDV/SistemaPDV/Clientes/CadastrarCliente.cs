namespace SistemaPDV.Clientes;

public class CadastrarCliente
{

    public static Dictionary<string, DadosCliente> cliente = new Dictionary<string, DadosCliente>();
    public static int codigoCliente = 0;
    public static void AdicionarCliente()
    {
        Console.Write("\nDigite o nome do cliente: ");
        string nome = Console.ReadLine()!;

        Console.Write($"Digite o CPF de {nome}: ");
        string cpf = Console.ReadLine()!;

        Console.Write($"Digite o email de {nome}: ");
        string email = Console.ReadLine()!;

        Console.Write($"Digite o numero de telefone de {nome}: ");
        string telefone = Console.ReadLine()!;

        Console.Write($"Digite a data de nascimento de {nome}: ");
        string dataDeNascimentoStr = Console.ReadLine()!;
        DateTime dataDenascimento = DateTime.Parse(dataDeNascimentoStr);

        codigoCliente++;

        Console.WriteLine($"\nDados Cadastrados:" +
            $"\nCodigo: {codigoCliente}" +
            $"\nNome: {nome}" +
            $"\nCPF: {cpf}" +
            $"\nE-mail: {email}" +
            $"\nTelefone: {telefone}" +
            $"\nData de Nascimento: {dataDenascimento.ToString("dd/MM/yyyy")}");
        DadosCliente novoCliente = new DadosCliente(codigoCliente, nome, cpf, email, telefone, dataDenascimento);
        cliente[cpf] = novoCliente;
    }
}
