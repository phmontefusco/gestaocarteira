namespace gestaocarteira.domain.interfaces;

public interface IProdutoRepository
{

    Task<IEnumerable<Produto>> GetProdutoAsync();
    Task<Produto> GetByIdAsync(int? id);

    Task<Produto> CreateAsync(Produto produto);
    Task<Produto> UpdateAsync(Produto produto);
    Task<Produto> RemoveAsync(Produto produto);    
}
