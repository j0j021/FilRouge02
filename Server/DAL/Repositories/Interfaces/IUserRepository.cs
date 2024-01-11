using User = Domain.Entities.User;

namespace DAL.Repositories.Interfaces;

public interface IUserRepository : IGenericReadRepository<int, User>, IGenericWriteRepository<User>

{
    public Task<User> GetByNameAsync(string name);
    public Task<User> GetRoleAsync(string Name, string Password);
    public Task<int> AssignerMaterielAsync(int idUser, int idMat, DateTime debut, DateTime fin);
}
