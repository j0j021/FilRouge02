using Domain.Entities;

namespace DAL.Repositories.Interfaces;

public interface ICategorieRepository : IGenericReadRepository<int, Categorie>, IGenericWriteRepository<Categorie>
{
    public Task<int> AddCategorieAsync(Categorie categorie);
    public Task<int> DeleteCategorieAsync(int id);
    public Task<int> UpdateCategorieAsync(int id, Categorie categorie);
    public Task<IEnumerable<Categorie>> GetCategorieMaterielAsync(int id);
}

