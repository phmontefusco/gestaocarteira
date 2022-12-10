namespace gestaocarteira.domain.interfaces;
public interface IAgendaRepository
{
    Task<IEnumerable<Agenda>> GetAgendaAsync();
    Task<Agenda> GetByIdAsync(int? id);

    Task<Agenda> CreateAsync(Agenda agenda);
    Task<Agenda> UpdateAsync(Agenda agenda);
    Task<Agenda> RemoveAsync(Agenda agenda);    
    
}