namespace Hotel.Core.Entities;

public class TipoQuarto : EntidadeBase
{
    public Guid TipoQuartoId { get; set; }
    public string Nome { get; set; }

    public Task AdicionarTipoQuartoAsync()
    {
        return Task.CompletedTask;
    }
    public Task<TipoQuarto> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<List<TipoQuarto>> AbterTodosAsync()
    {
        return Task.FromResult(new List<TipoQuarto>());
    }
    
    public Task<TipoQuarto> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task RemoverAsync(Guid ip)
    {
        return Task.CompletedTask;
    }
}