namespace SistemaPDV.Clientes;

public class RemoverClientes
{
    public static void RemoverCliente(Dictionary<string, DadosCliente> cliente)
    {
        Console.Write("Digite o CPF do cliente que deseja remover: ");
        string cpf = Console.ReadLine()!;

        if (cliente.TryGetValue(cpf, out DadosCliente cpfCliente))
        {
            Console.WriteLine($"Cadastro encontrado em nome de {cpfCliente.Nome.ToUpper()}");
            Console.Write("Deseja realmente excluir este cliente? [S/N]: ");
            string resposta = Console.ReadLine()!.ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine($"Cadastro de {cpfCliente.Nome} removido!");
                cliente.Remove(cpf);
            }
            else
            {
                Console.WriteLine("Operacao Cancelada!");
            }
        }
        else
        {
            Console.WriteLine("Cadastro nao encontrado!");
        }
    }
}
