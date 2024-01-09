using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Domain;

public static class DomaineExtension
{
    public static IServiceCollection addDomain(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}
