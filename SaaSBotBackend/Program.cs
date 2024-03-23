using System.Net;
using MemwLib.Http;
using MemwLib.Http.Types;
using MemwLib.Http.Types.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SaaSBotBackend.Services;

namespace SaaSBotBackend;

internal static class Program
{
    private static readonly IHost Provider = BuildProvider();
    private static IServiceProvider Services => Provider.Services;
    
    private static async Task Main()
    {
        await Provider.RunAsync();
    }

    private static IHost BuildProvider()
    {
        HttpServer server = new(new HttpServerConfig
        {
            Address = IPAddress.Any,
#if DEBUG
            Port = 8080,
            ServerState = ServerStates.Development
#else
            Port = 10001
            ServerState = ServerStates.Production
#endif
        });
        
        HostApplicationBuilder builder = new();
        
        builder.Services
            .AddSingleton(server)
            .AddHostedService<HttpServerService>();

        return builder.Build();
    }
}