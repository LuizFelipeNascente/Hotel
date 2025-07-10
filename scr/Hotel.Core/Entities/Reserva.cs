namespace Hotel.Core.Entities;

public class Reserva : EntidadeBase
{
    public Guid ReservaId { get; set; }
    public Guid DonoReservaId { get; set; }
    public Guid QuartoId { get; set; }
    public int TotalHospedes { get; set; }
    public DateTime CheckinPrevisto { get; set; }
    public DateTime CheckoutPrevisto { get; set; }
    public Guid MiniBarId { get; set; }
    public Guid ServicoReservaId { get; set; }
    public int QtDiasReservados { get; set; }   
    public decimal ValorTotalReserva { get; set; }
    public decimal ValorTotalHospedagem { get; set; }
    public decimal ValorTotalAbertoHospedagem { get; set; }
    public DateTime CheckinRealizado { get; set; }
    public DateTime CheckoutRealizado { get; set; }
    public bool CheckinConfirmado { get; set; }
    public bool CheckoutConfirmado { get; set; }
    public bool ReservaCancelada { get; set; }
    
    public Task AdicionarReservaAsync()
    {
        return Task.CompletedTask;
    }
    public Task<Reserva> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<Reserva> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task<Reserva> RealizarChekin(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task<Reserva> RealizarChekout(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task<Reserva> CancelarReserva(Guid id)
    {
        return Task.FromResult(this);
    }
    
    public Task AdicionarMiniBarAsync()
    {
        return Task.CompletedTask;
    }
    
    public Task AdicionarServicoReservaAsync()
    {
        return Task.CompletedTask;
    }
    
    public Task CalcularValorTotalReserva()
    {
        return Task.CompletedTask;
    }
    
    public Task CalcularValorTotalHospedagem()
    {
        return Task.CompletedTask;
    }
   
}