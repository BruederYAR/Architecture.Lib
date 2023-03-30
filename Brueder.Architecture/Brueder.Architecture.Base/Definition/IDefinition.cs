using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Brueder.Architecture.Base.Definition
{
    public interface IDefinition
    {
        bool Enabled { get; }

        void ConfigureServicesAsync(IServiceCollection services, WebApplicationBuilder builder);

        void ConfigureApplicationAsync(WebApplication app);
    }
}