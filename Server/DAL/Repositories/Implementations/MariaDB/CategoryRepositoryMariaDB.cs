using DAL.Repositories.Interfaces;
using DAL.Sessions.Interfaces;
using Dapper;
using Domain.Entities;
using MySql.Data.MySqlClient;

namespace DAL.Repositories.Implementations.MariaDB;

internal class CategoryRepositoryMariaDB : ICategorieRepository
{
    private readonly IDBSession db;

    private readonly MySqlConnection _connection = new("Server=lab006.2isa.org;Port=33006;Database=ticketing&message;UID=root;PWD=9641lab006");
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    public CategoryRepositoryMariaDB(IDBSession dBSession)
    {
        db = dBSession;
    }

    public Task<Categorie> AddAsync(Categorie entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Categorie entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Categorie>> GetCategoriesAsync()
    {
        await OpenConnectionAsync();
        var res = await db.Connection.QueryAsync<Categorie>("SELECT * FROM Categories");
        await CloseConnectionAsync();
        return res;
        throw new NotImplementedException();
    }

    public async Task<Categorie> GetByIdAsync(int id)
    {
        await OpenConnectionAsync();
        string q = "Select * FROM Categories WHERE Id = @id";
        var res = await db.Connection.QueryFirstAsync<Categorie>(q, new { id });
        await CloseConnectionAsync();
        return res;

        throw new NotImplementedException();
    }

    public Task<Categorie> UpdateAsync(Categorie entity)
    {
        throw new NotImplementedException();

    }
    public async Task OpenConnectionAsync()
    {
        await _semaphore.WaitAsync();
        await _connection.OpenAsync();
    }
    public async Task CloseConnectionAsync()
    {
        await _connection.CloseAsync();
        _semaphore.Release();
    }

    public async Task<IEnumerable<Categorie>> GetAllAsync()
    {

        await OpenConnectionAsync();
        var res = await db.Connection.QueryAsync<Categorie>("SELECT * FROM Categories");
        await CloseConnectionAsync();
        return res;



    }
    public async Task<int> AddCategorieAsync(Categorie entity)
    {
        await OpenConnectionAsync();
        string label = entity.Label;
        string q = "INSERT INTO Categories (label) VALUES (@label)";
        var res = await db.Connection.ExecuteAsync(q, new { label });
        await CloseConnectionAsync();
        return res;
    }


    public async Task<int> DeleteCategorieAsync(int id)
    {
        await OpenConnectionAsync();
        string q = "DELETE FROM Categories WHERE Id = @id";
        var res = await db.Connection.ExecuteAsync(q, new { id });
        await CloseConnectionAsync();
        return res;
    }

    public async Task<int> UpdateCategorieAsync(int id, Categorie categorie)
    {
        await OpenConnectionAsync();
        string q = "UPDATE Categories SET Label = @label WHERE Id = @id";
        var res = await db.Connection.ExecuteAsync(q, new { id, categorie.Label });
        await CloseConnectionAsync();
        return res;
        throw new NotImplementedException();
    }
}
