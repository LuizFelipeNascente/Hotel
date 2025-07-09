namespace Hotel.Core.Entities;

public class ServicoReservaItem
{
    public Guid ServicoReservaItemId { get; set; }
    public Guid ServicoReservaId { get; set; }
    public Guid ServicoId { get; set; }
    public int QtItem { get; set; }
    public decimal PrecoUnitario { get; set; }
}