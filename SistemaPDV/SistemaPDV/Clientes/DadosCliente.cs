namespace SistemaPDV.Clientes;

public class DadosCliente
{
    public DadosCliente(int codigoCliente, string nome, string cpf, string email, string telefone, DateTime dataNascimento)
    {
        CodigoCliente = codigoCliente;
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        DataNascimento = dataNascimento;
    }

    public int CodigoCliente { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
}
