using BLL.Interfaces;
using DAL;
using Domain.Entities;

namespace BLL.Implementation;

public class CategorieService : ICategorieService
{
    private readonly IUOW? _dbContext;
    public CategorieService(IUOW? dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<int> AddCategorieAsync(Categorie categorie)
    {
        var cat = _dbContext.Categorie.AddCategorieAsync(categorie);
        return cat;
        //throw new NotImplementedException();
    }

    public Task<int> DeleteCategorieAsync(int id)
    {
        var res = _dbContext.Categorie.DeleteCategorieAsync(id);
        return res;
    }

    public Task<Categorie> GetCategorieById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Categorie>> GetCategoriesAsync()
    {
        var Cat = await _dbContext.Categorie.GetAllAsync();
        return Cat;
        //throw new NotImplementedException();
    }

    public async Task<IEnumerable<Materiel>> GetMaterielByIdCat(int id)
    {
        var Mat = await _dbContext.Materiels.GetMaterielByCategorieAsync(id);
        return Mat;
        throw new NotImplementedException();
    }

    public async Task<int> UpdateCategorieAsync(int id, Categorie categorie)
    {
        var cat = await _dbContext.Categorie.UpdateCategorieAsync(id, categorie);
        return cat;
        throw new NotImplementedException();
    }
    public async Task<IEnumerable<Categorie>> GetCategorieMaterielAsync(int id)
    {
        var cat = await _dbContext.Categorie.GetCategorieMaterielAsync(id);
        return cat;
    }
}









