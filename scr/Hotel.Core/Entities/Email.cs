using System.Text.RegularExpressions;

namespace Hotel.Core.Entities;

public class Email
{
    public Email(string email)
    {
        if (!ValidarEmail(email))
            throw new ArgumentException("Email invalido.");

        EnderecoEmail = email;
    }

    public string EnderecoEmail { get; set; }

    public bool ValidarEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(EnderecoEmail)) return false;
        return Regex.IsMatch(EnderecoEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}