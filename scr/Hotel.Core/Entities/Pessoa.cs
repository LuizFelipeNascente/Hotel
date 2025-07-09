namespace Hotel.Core.Entities;

public class Pessoa
{
    public Guid PessoaId { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Rg Rg { get; set; }
    public Cpf Cpf { get; set; }
    public int TipoPessoa { get; set; }
    public DateTime DataNascimento { get; set; }
    
    public List<DetalhePessoa> DetalhePessoa { get; set; }

    public Task AdicionarPessoaAsync()
    {
        return Task.CompletedTask;
    }
    public Task<Pessoa> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<List<Pessoa>> AbterTodosAsync()
    {
        return Task.FromResult(new List<Pessoa>());
    }
    
    public Task<Pessoa> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task RemoverAsync(Guid id)
    {
        return Task.CompletedTask;
    }
}