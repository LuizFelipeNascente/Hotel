namespace Hotel.Core.Entities;

public class ServicoReserva
{
    public Guid ServicoReservaId { get; set; }
    public int QtdItens { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ServicoReservaItem> ServicosItens { get; set; } = new();
    
    public Task<ServicoReserva> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task<ServicoReserva> AtualizarAsync(Guid id)
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