using Domain.Entities;

namespace BLL.Interfaces
{
    public interface ICategorieService
    {
        public Task<IEnumerable<Categorie>> GetCategoriesAsync();
        public Task<int> UpdateCategorieAsync(int id, Categorie categorie);
        public Task<Categorie> GetCategorieById(int id);
        public Task<int> AddCategorieAsync(Categorie categorie);
        public Task<int> DeleteCategorieAsync(int id);
        public Task<IEnumerable<Materiel>> GetMaterielByIdCat(int id);
        public Task<IEnumerable<Categorie>> GetCategorieMaterielAsync(int id);
    }
}
