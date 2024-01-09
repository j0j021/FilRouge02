using DAL.Repositories.Interfaces;
using DAL.Sessions.Interfaces;
using Domain.Entities;
using MySql.Data.MySqlClient;
namespace DAL.Repositories.Implementations.MariaDB;
using Dapper;
using Domain.DTO.Request;

internal class MaterielRepositoryMariaDB : IMaterielRepository
{
    private readonly IDBSession db;
    private readonly MySqlConnection _connection = new("Server=lab006.2isa.org;Port=33006;Database=ticketing&message;UID=root;PWD=9641lab006");
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    public MaterielRepositoryMariaDB(IDBSession dBSession)
    {

        db = dBSession;



    }

    public Task<Materiel> AddAsync(Materiel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Materiel entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Materiel>> GetAllAsync()
    {
        await OpenConnectionAsync();
        string q = "SELECT * FROM Materiel";
        return await db.Connection.QueryAsync<Materiel>(q);

    }

    public async Task<Materiel> GetByIdAsync(int id)
    {
        await OpenConnectionAsync();
        string q = "SELECT * FROM Materiel WHERE Id=@id";
        return await db.Connection.QueryFirstAsync<Materiel>(q, new { id });


    }

    public Task<Materiel> UpdateAsync(Materiel entity)
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

    public async Task<int> DeleteMaterielAsync(int id)
    {
        await OpenConnectionAsync();
        string q = "DELETE FROM Materiel WHERE Id = @id";
        return await db.Connection.ExecuteAsync(q, new { id });

    }
    public async Task<int> UpdateMaterielAsync(Materiel materiel)
    {
        await OpenConnectionAsync();
        string q = "UPDATE Materiel SET nom = @Nom WHERE Id = @Id";
        var res = await db.Connection.ExecuteAsync(q, new { materiel.Id, materiel.Nom });
        return res;
    }

    public async Task<IEnumerable<Materiel>> GetMaterielByCategorieAsync(int IdCategorie)
    {
        await OpenConnectionAsync();
        string q = "SELECT M.* FROM Materiel M ,MaterielCategories mc,users u WHERE M.Id = mc.IdMateriel AND mc.IdCategories = @IdCategorie GROUP BY IdCategories";
        var res = await db.Connection.QueryAsync<Materiel>(q, new { IdCategorie });
        await CloseConnectionAsync();
        return res;

    }

    public async Task<int> AddMaterielCategorieAsync(AddMaterielDTORequest materiel)
    {
        await OpenConnectionAsync();
        string Nom = materiel.Nom;
        string q = "INSERT  INTO Materiel (nom) VALUES (@Nom); SELECT LAST_INSERT_ID() ";
        var result = await _connection.QueryAsync<int>(q, new { Nom });
        int idMat = result.Single();
        int idCat = materiel.IdCat;
        string qComposition = "INSERT INTO MaterielCategories (IdMateriel,IdCategories) VALUES (@idMat,@idCat)";
        var res = await _connection.ExecuteAsync(qComposition, new { idMat, idCat });
        return res;
        throw new NotImplementedException();
    }
}

