using GrpcServiceTest.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Server.IntegrationTests.Helpers
{
    public class TestStartUp
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment _)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();
            });
        }
    }
}