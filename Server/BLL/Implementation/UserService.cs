using BLL.Interfaces;
using DAL;
using Domain.DTO.Request;
using Domain.Entities;
using Domaine.DTO.Request;
using Domaine.DTO.Response;

namespace BLL.Implementation;

public class UserService : IUserService
{
    private readonly IUOW _dbContext;

    public UserService(IUOW dbContext)
    {

        _dbContext = dbContext;

    }
    public async Task<int> AssignerMaterielAsync(AssignerMaterielDTORequest lien)
    {
        int res = await _dbContext.User.AssignerMaterielAsync((int)lien.idUser, lien.idMateriel, (DateTime)lien.Debut, (DateTime)lien.Fin);
        return res;
    }

    public async Task<GetUserByNameDTOResponse> GetUserAsync()
    {
        var user = await _dbContext.User.GetAllAsync();
        throw new NotImplementedException();
    }



    public async Task<User> GetUserByNameAsync(GetUserByNameDTORequest name)
    {
        var user = await _dbContext.User.GetByNameAsync(name.Name);
        return user;
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        var user = await _dbContext.User.GetAllAsync();
        return user;
        throw new NotImplementedException();
    }




}









