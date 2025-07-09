using System.Text.RegularExpressions;

namespace Hotel.Core.Entities;

public class Cpf
{
    public Cpf(string numero)
    {
        if (!ValidarCpf(numero))
            throw new ArgumentException("cpf invalido.");

        NumeroCpf = numero;
    }

    public string NumeroCpf { get; set; }

    public bool ValidarCpf(string numero)
    {
        if (string.IsNullOrWhiteSpace(NumeroCpf)) return false;
        var cpf = Regex.Replace(NumeroCpf, "[^0-9]", "");
        if (cpf.Length != 11 || new string(cpf[0], 11) == cpf) return false;

        int[] mult1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string temp = cpf.Substring(0, 9);
        int sum = 0;
        for (int i = 0; i < 9; i++) sum += int.Parse(temp[i].ToString()) * mult1[i];
        int rem = sum % 11;
        int dig1 = rem < 2 ? 0 : 11 - rem;

        temp += dig1;
        sum = 0;
        for (int i = 0; i < 10; i++) sum += int.Parse(temp[i].ToString()) * mult2[i];
        rem = sum % 11;
        int dig2 = rem < 2 ? 0 : 11 - rem;

        return cpf.EndsWith(dig1.ToString() + dig2.ToString());
    }
}