using DAL.Sessions.Interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Sessions.Implementations;
internal class DBSessionMariaDB : IDBSession, IDisposable
{

    public IDbConnection Connection { get; private set; }

    public IDbTransaction Transaction { get; set; }

    public DBSessionMariaDB(IConfiguration configuration)
    {
        string? connectionString = configuration.GetSection("ConnectionString").Value;

        Connection = new MySqlConnection(connectionString);
        Connection.Open();
    }

    public void Dispose()
    {
        Connection?.Dispose();
    }
}
