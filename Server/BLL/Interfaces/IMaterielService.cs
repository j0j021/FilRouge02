using Domain.DTO.Request;
using Domain.Entities;
namespace BLL.Interfaces;

public interface IMaterielService
{
    public Task<IEnumerable<Materiel>> GetMaterielAsync();
    public Task<int> UpdateMaterielAsync(Materiel materiel);
    public Task<IEnumerable<Materiel>> GetMaterielByCategorieAsync(int IdCategorie);
    public Task<int> DeleteMaterielAsync(int IdMateriel);
    public Task<int> AddMaterielCategorieAsync(AddMaterielDTORequest materiel);
}
