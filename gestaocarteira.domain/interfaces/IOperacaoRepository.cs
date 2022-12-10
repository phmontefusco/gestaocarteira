namespace gestaocarteira.domain.interfaces;

public interface IOperacaoRepository
{
    
    Task<IEnumerable<Operacao>> GetOperacaoAsync();
    Task<Operacao> GetByIdAsync(int? id);

    Task<Operacao> CreateAsync(Operacao operacao);
    Task<Operacao> UpdateAsync(Operacao operacao);
    Task<Operacao> RemoveAsync(Operacao operacao);
        
}
