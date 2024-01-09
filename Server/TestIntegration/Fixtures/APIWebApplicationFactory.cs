using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;

namespace TestIntegration.Fixtures
{
    public class APIWebApplicationFactory : WebApplicationFactory<Program>
    {
        public IConfiguration Configuration { get; set; }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                Configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.Integrations.json")
                    .Build();
                config.AddConfiguration(Configuration);
            });
        }
    }
}
