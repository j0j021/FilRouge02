using Domain.DTO.Request;
using Domain.Entities;

namespace DAL.Repositories.Interfaces;

public interface IMaterielRepository : IGenericReadRepository<int, Materiel>, IGenericWriteRepository<Materiel>
{
    public Task<int> DeleteMaterielAsync(int id);
    public Task<int> UpdateMaterielAsync(Materiel materiel);
    public Task<IEnumerable<Materiel>> GetMaterielByCategorieAsync(int IdCategorie);
    public Task<int> AddMaterielCategorieAsync(AddMaterielDTORequest materiel);

}