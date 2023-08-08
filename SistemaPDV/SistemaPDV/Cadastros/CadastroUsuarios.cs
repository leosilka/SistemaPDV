using SistemaPDV.Menus;
using SistemaPDV.Modelos;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SistemaPDV.Cadastros;


internal class CadastroUsuarios
{
    private Dictionary<string, Usuarios> usuarios;
    private static int proximoCodigoCliente = 0;

    public CadastroUsuarios(Dictionary<string, Usuarios> usuarios)
    {
        this.usuarios = usuarios;
    }

    Logos tela = new Logos();
    public void AdicionarUsuario()
    {
        Console.Write("Digite o nome do cliente: ");
        string respostaNome = Console.ReadLine()!;
        Console.Write($"Digite o CPF do {respostaNome}: ");
        string respostaCpf = Console.ReadLine()!;

        if(usuarios.ContainsKey(respostaCpf))
        {
            Console.WriteLine("CPF ja cadastrado!");
            return;
        }

        // Validacao de CPF
        if (!ValidarCPF(respostaCpf))
        {
            Console.WriteLine("CPF invalido!");
            return;
        }

        Console.Write($"Digite o email de {respostaNome}: ");
        string respostaEmail = Console.ReadLine()!;

        Console.Write($"Digite o telefone de {respostaNome}: ");
        string respostaTelefone = Console.ReadLine()!;

        Console.Write($"Digite o data de nascimento de {respostaNome}: ");
        string respostaDataDeNascimentoStr = Console.ReadLine()!;
        DateTime respostaDataDeNascimento = DateTime.Parse(respostaDataDeNascimentoStr);

        proximoCodigoCliente++;

        Usuarios novoUsuario = new Usuarios(proximoCodigoCliente, respostaNome, respostaCpf, respostaEmail, respostaTelefone, respostaDataDeNascimento);
        usuarios.Add(respostaCpf, novoUsuario);
               
        tela.TelaDeCarregamento();
        Console.WriteLine($"\nUsuario {respostaNome} registrado com sucesso!");
    }
    
    public void ConsultarUsuario()
    {
        Console.WriteLine(@"Qual opcao de consulta:

[1] - Todos os usuarios
[2] - Por CPF
");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                ListarUsuarios(usuarios);
                break;

            case 2:
                Console.Write($"Digite o CPF para pesquisa: ");
                string respostaCpf = Console.ReadLine()!;
                tela.TelaDeCarregamento();
                // Consulta o usuario pelo CPF
                Usuarios usuarioEncontrado = ConsultarPorCpf(respostaCpf);

                if (usuarioEncontrado != null)
                {
                    Console.WriteLine(@$"
Usuário encontrado:
Cod. Cliente: {usuarioEncontrado.CodigoCliente}
Nome: {usuarioEncontrado.Nome}
CPF: {usuarioEncontrado.Cpf}
Email: {usuarioEncontrado.Email}
Telefone: {usuarioEncontrado.Telefone}
Data de Nascimento: {usuarioEncontrado.DataDeNascimento}
");
                }
                else
                {
                    Console.WriteLine("\nUsuário não encontrado!");
                }
                break;
        }
    }

    public void ListarUsuarios(Dictionary<string, Usuarios> usuarios)
    {
        Console.WriteLine("Lista de todos os usuarios:\n");
        foreach (var usuario in usuarios.Values)
        {
            Console.WriteLine($"Cod. Cliente: {usuario.CodigoCliente}");
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"CPF: {usuario.Cpf}");
            Console.WriteLine($"Email: {usuario.Email}");
            Console.WriteLine($"Telefone: {usuario.Telefone}");
            Console.WriteLine($"Data de Nascimento: {usuario.DataDeNascimento}\n");
        }
    }

    public void ModificarUsuario()
    {
        Console.Write($"Digite o CPF do usuario que deseja modificar: ");
        string respostaCpf = Console.ReadLine()!;

        Usuarios usuarios = ConsultarPorCpf(respostaCpf);

        if (usuarios != null)
        {
            Console.WriteLine($"Vamos realizar as alteracoes que deseja.\nObservacao: Por motivos de seguranca, não realizamos alteracao de CPF!");

            Console.Write($"Nome: ");
            string novoNome = Console.ReadLine()!;
            usuarios.Nome = novoNome;

            Console.Write($"Email: ");
            string novoEmail = Console.ReadLine()!;
            usuarios.Email = novoEmail;

            Console.Write($"Telefone: ");
            string novoTelefone = Console.ReadLine()!;
            usuarios.Telefone = novoTelefone;

            Console.Write($"Data de Nascimento: ");
            string novaDataDeNascimentoStr = Console.ReadLine()!;
            DateTime novaDataDeNascimento = DateTime.Parse(novaDataDeNascimentoStr);
            usuarios.DataDeNascimento = novaDataDeNascimento;

            Console.WriteLine($"Alterado com sucesso o cadastro do CPF {respostaCpf}");
        }
        else
        {
            Console.WriteLine($"CPF {respostaCpf} não encontrado!");
        }
    }

    public void RemoverUsuario()
    {
        Console.Write($"Digite o CPF do cliente que deseja modificar: ");
        string respostaCpf = Console.ReadLine()!;

        Usuarios usuarioEncontrado = ConsultarPorCpf(respostaCpf);

        if (usuarioEncontrado != null)
        {
            Console.WriteLine($"Deseja realmente excluir o cadastro do cliente {usuarioEncontrado.Nome}? [S/N]: ");
            string respostaExclusao = Console.ReadLine()!.ToUpper();

            if (respostaExclusao == "S")
            {
                Console.WriteLine($"Cadastro de {usuarioEncontrado.Nome} removido!0");
                usuarios.Remove(respostaCpf);
            }
            else
            {
                Console.WriteLine("Exclusao Cancelada!");
            }
        }
        else
        {
            Console.WriteLine("Usuario nao encontrado!");
        }
    }

    public Usuarios ConsultarPorCpf(string cpf)
    {
        if (usuarios.TryGetValue(cpf, out Usuarios? usuario))
        {
            return usuario;
        }
        else
        {
            return null; // Retorna null se o CPF não for encontrado no dicionário
        }
    }

    static bool ValidarCPF(string cpf)
    {
        // Remove os pontos e traço do CPF para ficar apenas com os dígitos
        cpf = Regex.Replace(cpf, @"[^\d]", "");

        // Verifica se o CPF tem 11 dígitos
        if (cpf.Length != 11)
            return false;

        // Verifica se todos os dígitos são iguais, o que não é um CPF válido
        if (new string(cpf[0], 11) == cpf)
            return false;

        // Cálculo para verificar se os dígitos verificadores estão corretos
        int soma1 = 0;
        for (int i = 0; i < 9; i++)
        {
            soma1 += (cpf[i] - '0') * (10 - i);
        }

        int digito1 = 11 - (soma1 % 11);
        if (digito1 >= 10)
            digito1 = 0;

        int soma2 = 0;
        for (int i = 0; i < 10; i++)
        {
            soma2 += (cpf[i] - '0') * (11 - i);
        }

        int digito2 = 11 - (soma2 % 11);
        if (digito2 >= 10)
            digito2 = 0;

        return (cpf[9] - '0' == digito1) && (cpf[10] - '0' == digito2);
    }
}
