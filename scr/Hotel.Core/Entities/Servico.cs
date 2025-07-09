namespace Hotel.Core.Entities;

public class Servico
{
    public Guid ServicoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }

    public Task AdicionarServicoAsync()
    {
        return Task.CompletedTask;
    }
    public Task<Servico> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<List<Servico>> AbterTodosAsync()
    {
        return Task.FromResult(new List<Servico>());
    }
    
    public Task<Servico> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task RemoverAsync(Guid id)
    {
        return Task.CompletedTask;
    }
}