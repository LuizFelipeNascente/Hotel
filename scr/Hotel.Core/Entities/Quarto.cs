namespace Hotel.Core.Entities;

public class Quarto
{
    public Guid QuartoId { get; set; }
    public Guid TipoQuartoId { get; set; }
    public int Numero { get; set; }
    public decimal ValorDiaria { get; set; }
    public int Situacao { get; set; }
    public int CapacidadeMaxima { get; set; }
    // public string MiniBarId { get; set; }

    public Task AdicionarQuartoAsync()
    {
        return Task.CompletedTask;
    }

    public Task<Quarto> ObeterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task<List<Quarto>> ObterTodosAsync()
    {
        return Task.FromResult(new List<Quarto>());
    }

    public Task<Quarto> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }
   
    public Task RemoverAsync(Guid id)
    {
        return Task.CompletedTask;
    }
}