namespace SistemaPDV.Clientes;

public class ModificarCadastroCliente
{
    public static void ModificarCliente(Dictionary<string, DadosCliente> cliente)
    {
        Console.Write("Digite o CPF do cliente que deseja modificar o cadastro: ");
        string cpf = Console.ReadLine()!;

        if (cliente.TryGetValue(cpf, out DadosCliente dadosCliente))
        {
            bool continuar = true;

            Console.WriteLine($"CPF encontrado no cadastro.\nVamos realizar as alteracoes." +
                $"(Por motivos de seguranca, nao realizaremos a alteracao do CPF)");

            while (continuar)
            {
                Console.WriteLine(@"Escolha a opcao que deseja:
    [1] - Mudar Nome
    [2] - Mudar Email
    [3] - Mudar Telefone
    [4] - Mudar Data de Nascimento");
                Console.Write("Digite a opcao que deseja: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o novo nome: ");
                        string nome = Console.ReadLine()!;
                        dadosCliente.Nome = nome;
                        break;

                    case 2:
                        Console.Write("Digite o novo e-mail: ");
                        string email = Console.ReadLine()!;
                        dadosCliente.Email = email;
                        break;

                    case 3:
                        Console.Write("Digite o novo telefone: ");
                        string telefone = Console.ReadLine()!;
                        dadosCliente.Telefone = telefone;
                        break;

                    case 4:
                        Console.Write("Digite a nova data de nascimento: ");
                        string dataDeNascimentoStr = Console.ReadLine()!;
                        DateTime dataDenascimento = DateTime.Parse(dataDeNascimentoStr);
                        dadosCliente.DataNascimento = dataDenascimento;
                        break;

                    default: Console.WriteLine("Opcao Invalida!"); break;
                }
                Console.Write("Deseja continuar? [S/N]: ");
                string resposta = Console.ReadLine()!.ToUpper();
                if (resposta == "S")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
        }
        else
        {
            Console.WriteLine("CPF nao encontrado no cadastro.");
        }
    }
}
