using System.Text.RegularExpressions;

namespace SistemaPDV.Modelos;

internal class Usuarios
{
    public Usuarios(int codigoCliente, string nome, string cpf, string email, string telefone, DateTime dataDeNascimento)
    {
        CodigoCliente = codigoCliente;
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        DataDeNascimento = dataDeNascimento;
    }

    public int CodigoCliente { get; }
    public string? Nome { get; set; }
    public string? Cpf { get; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public DateTime DataDeNascimento { get; set; }
  
}
