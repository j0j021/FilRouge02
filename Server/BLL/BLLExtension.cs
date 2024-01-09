using BLL.Implementation;
using BLL.Implementations;
using BLL.Interfaces;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BLL;
public class BLLOptions
{
    //Here you can add your custom options
}

public static class BLLExtension
{
    public static IServiceCollection addBLL(this IServiceCollection services, Action<BLLOptions> configure = null)
    {
        BLLOptions options = new();
        configure?.Invoke(options);
        services.AddTransient<IMaterielService, MaterielService>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<ICategorieService, CategorieService>();
        services.AddTransient<ISecurityService, SecurityService>();
        services.AddDAL();
        return services;
    }
}
