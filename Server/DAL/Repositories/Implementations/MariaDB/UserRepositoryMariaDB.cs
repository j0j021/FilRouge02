using DAL.Repositories.Interfaces;
using DAL.Sessions.Interfaces;
using Dapper;
using Domain.Entities;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;
namespace DAL.Repositories.Implementations.MariaDB;

internal class UserRepositoryMariaDB : IUserRepository
{
    private readonly IDBSession db;

    private readonly MySqlConnection _connection = new("Server=lab006.2isa.org;Port=33006;Database=ticketing&message;UID=root;PWD=9641lab006");
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    public UserRepositoryMariaDB(IDBSession dBSession)
    {
        db = dBSession;
    }

    public Task<User> AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        await OpenConnectionAsync();
        string q = "SELECT * FROM  users";
        var res = await db.Connection.QueryAsync<User>(q);
        await CloseConnectionAsync();
        return res;

    }

    public async Task<User> GetByNameAsync(string name)
    {
        await OpenConnectionAsync();
        string q = "SELECT * FROM users WHERE name =@name ";
        var res = await db.Connection.QueryFirstAsync<User>(q, new { name });
        await CloseConnectionAsync();
        return res;
    }

    public Task<User> UpdateAsync(User entity)
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

    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="Password"></param>
    /// <returns>role du user si mmot de passe est valide</returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<User> GetRoleAsync(string name, string Password)
    {
        string salt = BC.GenerateSalt(8, 'y');


        await OpenConnectionAsync();
        var q = "SELECT password as Password,Label as role  FROM `ticketing&message`.users u, Role r ,UserRole ur WHERE name=@name  AND ur.IdUser=u.id AND r.Id =ur.IdRole ";
        var result = await db.Connection.QueryAsync<User>(q, new { name });
        User login = result.Single();

        string? res = login.Password;
        if (BC.Verify(Password, res))
            return login;
        else return null;
        throw new NotImplementedException();
    }
    public async Task<int> AssignerMaterielAsync(int idUser, int idMat, DateTime debut, DateTime fin)
    {
        await OpenConnectionAsync();

        string q = "Update Materiel SET Proprietaire =(SELECT name from users WHERE id = @idUser),Debut = @debut,Fin = @fin WHERE Id = @idMat";
        var res = await _connection.ExecuteAsync(q, new { idUser, idMat, debut, fin });
        return res;
    }
}

