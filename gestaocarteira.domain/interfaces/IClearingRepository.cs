namespace gestaocarteira.domain.interfaces;

public interface IClearingRepository
{

    Task<IEnumerable<Clearing>> GetClearingAsync();
    Task<Clearing> GetByIdAsync(int? id);

    Task<Clearing> CreateAsync(Clearing clearing);
    Task<Clearing> UpdateAsync(Clearing clearing);
    Task<Clearing> RemoveAsync(Clearing clearing);    

}