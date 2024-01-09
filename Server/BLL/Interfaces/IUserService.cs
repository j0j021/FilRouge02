using Domain.DTO.Request;
using Domain.Entities;

namespace BLL.Interfaces;


public interface IUserService
{
    /// <summary>
    /// Onrécupère les infos du User à partir de son nom
    /// </summary>
    /// <param name="name"></param>
    /// <returns>User</returns>



    public Task<IEnumerable<User>> GetUsersAsync();
    public Task<int> AssignerMaterielAsync(AssignerMaterielDTORequest lien);

}
