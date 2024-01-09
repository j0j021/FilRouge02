using DAL.Repositories.Interfaces;

namespace DAL;

public interface IUOW : IDisposable
{
    IMaterielRepository Materiels { get; }
    ICategorieRepository Categorie { get; }
    IUserRepository User { get; }
}
