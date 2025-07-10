namespace Hotel.Core.Entities;

public class MiniBar : EntidadeBase
{
    public Guid MiniBarId { get; set; }
    public DateTime Iniciado { get; set; }
    public string Descricao { get; set; }
    public int QtdItens { get; set; }
    public decimal ValorTotal { get; set; }
    public List<MiniBarItem> MiniBarItens { get; set; } = new();

    public Task<MiniBar> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<MiniBar> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task RemoverAsync(Guid id)
    {
        return Task.CompletedTask;
    }
    
    public Task SomarValorTotal()
    {
        return Task.CompletedTask;
    }
}