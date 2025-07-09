using System.Text.RegularExpressions;

namespace Hotel.Core.Entities;

public class Rg
{
    public Rg(string numero)
    {
        if (!ValidarRg(numero))
            throw new ArgumentException("RG invaldo.");

        NumeroRg = numero;
    }

    public string NumeroRg { get; set; }

    public bool ValidarRg(string numero)
    {
        if (string.IsNullOrWhiteSpace(NumeroRg)) return false;
        var cleaned = Regex.Replace(NumeroRg, "[^0-9Xx]", "");
        return cleaned.Length >= 7 && cleaned.Length <= 9;
    }
}