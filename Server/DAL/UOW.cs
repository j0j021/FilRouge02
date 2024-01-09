using DAL.Repositories.Implementations.MariaDB;
using DAL.Repositories.Interfaces;
using DAL.Sessions.Interfaces;

namespace DAL;

internal class UOW : IUOW
{
    private readonly IDBSession db;
    public UOW(IDBSession dBSession)
    {
        db = dBSession;
    }
    public IMaterielRepository Materiels => new MaterielRepositoryMariaDB(db);
    public ICategorieRepository Categorie => new CategoryRepositoryMariaDB(db);
    public IUserRepository User => new UserRepositoryMariaDB(db);



    //public ICategorieRepository Categorie => throw new NotImplementedException();

    //public IUserRepository User => throw new NotImplementedException();

    public void BeginTransaction()
    {
        if (db.Transaction is null)
        {
            db.Transaction = db.Connection.BeginTransaction();

        }
    }
    public void Commit()
    {
        if (db.Transaction is not null)
        {
            db.Transaction.Commit();
            db.Transaction = null;
        }
    }
    public void Dispose()
    {
        if (db.Transaction is not null)
        {
            db.Transaction.Dispose();
            db.Transaction = null;
        }
    }




    public void Rollback()
    {
        if (db.Transaction is not null)
        {
            db.Transaction.Rollback();
            db.Transaction = null;
        }
    }
}
