using MauiSQLite.MVVM.Models;
using SQLite;

namespace MauiSQLite.Services;

public class AgendaService : IAgendaService
{
    private SQLiteAsyncConnection _dbConnection;
    public async Task InitializeAsync()
    {
        await SetUpDb();
    }
    private async Task SetUpDb()
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(Environment.
            GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Agenda2.db3");

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<Contato>();
        }
    }

    public async Task<int> AddContato(Contato contato)
    {
        return await _dbConnection.InsertAsync(contato);
    }

    public async Task<int> DeleteContato(Contato contato)
    {
        return await _dbConnection.DeleteAsync(contato);
    }
    public async Task<int> UpdateContato(Contato contato)
    {
        return await _dbConnection.UpdateAsync(contato);
    }

    public async Task<List<Contato>> GetContatos()
    {
        return await _dbConnection.Table<Contato>().ToListAsync();
    }

    public async Task<Contato> GetContato(int id)
    {
        return await _dbConnection.Table<Contato>().FirstOrDefaultAsync(x => x.Id == id);
    }
}
