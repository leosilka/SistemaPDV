using System.Text.RegularExpressions;

namespace SistemaPDV.Usuarios;

internal class ValidarCpf
{
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
