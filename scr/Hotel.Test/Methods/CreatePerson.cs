using Hotel.Core.Entities;
using Hotel.Core.Enums;

namespace Hotel.Test.Methods;

public class CreatePerson
{
    public (Pessoa, DetalhePessoa) AdicionarPessoaComDetalhes()
    {
        var pessoa = new Pessoa
        {
            PessoaId = Guid.NewGuid(),
            Nome = "Luiz",
            Sobrenome = "Felipe",
            Rg = new Rg("22222"),
            Cpf = new Cpf("12345678909"),
            TipoPessoa = (int)TipoPessoa.Fisica,
            DataNascimento = new DateTime(1993, 9, 21)
        };

        var detalhe = new DetalhePessoa
        {
            DetalhePessoaId = Guid.NewGuid(),
            PessoaId = pessoa.PessoaId,
            Email = new Email("luizemail.com"),
            Telefone = "629999999",
            EnderecoId = Guid.NewGuid()
        };

        return (pessoa, detalhe);
    }
}
