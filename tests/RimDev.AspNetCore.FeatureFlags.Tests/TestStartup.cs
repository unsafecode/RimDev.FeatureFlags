using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace RimDev.AspNetCore.FeatureFlags.Tests
{
    public class TestStartup
    {
        public static readonly FeatureFlagOptions Options = new FeatureFlagOptions
        {
            FeatureFlagAssemblies = new[] { typeof(TestStartup).Assembly },
            Provider = new InMemoryFeatureProvider()
        };

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFeatureFlags(Options);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseFeatureFlags(Options);
        }
    }
}