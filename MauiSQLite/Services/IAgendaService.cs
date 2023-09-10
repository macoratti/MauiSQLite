using MauiSQLite.MVVM.Models;

namespace MauiSQLite.Services;

public interface IAgendaService
{
    Task InitializeAsync();
    Task<List<Contato>> GetContatos();
    Task<Contato> GetContato(int contatoId);
    Task<int> AddContato(Contato contato);
    Task<int> UpdateContato(Contato contato);
    Task<int> DeleteContato(Contato contato);
}
