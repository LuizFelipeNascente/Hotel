namespace Hotel.Core.Entities;

public class Produto
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public Task AdicionarProdutoAsync()
    {
        return Task.CompletedTask;
    }
    public Task<Produto> ObterPorIdAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task<List<Produto>> AbterTodosAsync()
    {
        return Task.FromResult(new List<Produto>());
    }
    
    public Task<Produto> AtualizarAsync(Guid id)
    {
        return Task.FromResult(this);
    }

    public Task RemoverAsync(Guid id)
    {
        return Task.CompletedTask;
    }
}