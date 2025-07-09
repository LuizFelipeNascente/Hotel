namespace Hotel.Core.Entities;

public class MiniBarItem
{
    public Guid MiniBarItemId { get; set; }
    public Guid MiniBarId { get; set; }
    public Guid ProdutoId { get; set; }
    public int QtItem { get; set; }
    public decimal PrecoUnitario { get; set; }
}