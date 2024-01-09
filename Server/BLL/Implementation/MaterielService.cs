using BLL.Interfaces;
using DAL;
using Domain.DTO.Request;
using Domain.Entities;

namespace BLL.Implementation;

public class MaterielService : IMaterielService
{
    private readonly IUOW? _dbContext;
    public MaterielService(IUOW? dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> AddMaterielCategorieAsync(AddMaterielDTORequest materiel)
    {
        return await _dbContext.Materiels.AddMaterielCategorieAsync(materiel);
        throw new NotImplementedException();
    }

    public async Task<int> DeleteMaterielAsync(int IdMateriel)
    {
        return await _dbContext.Materiels.DeleteMaterielAsync(IdMateriel);
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Materiel>> GetMaterielAsync()
    {

        var Mat = await _dbContext.Materiels.GetAllAsync();

        return Mat;
    }


    public async Task<IEnumerable<Materiel>> GetMaterielByCategorieAsync(int IdCategorie)
    {
        return await _dbContext.Materiels.GetMaterielByCategorieAsync(IdCategorie);


    }



    public async Task<int> UpdateMaterielAsync(Materiel materiel)
    {
        var res = await _dbContext.Materiels.UpdateMaterielAsync(materiel);
        return res;

    }


}
