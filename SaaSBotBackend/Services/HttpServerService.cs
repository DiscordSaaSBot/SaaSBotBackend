using System.Text.RegularExpressions;
using MemwLib.Http;
using MemwLib.Http.Types;
using MemwLib.Http.Types.Collections;
using MemwLib.Http.Types.Entities;
using Microsoft.Extensions.Hosting;

namespace SaaSBotBackend.Services;

public class HttpServerService(HttpServer server) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        
        // CORS: this must be last
        server.AddEndpoint(RequestMethodType.Options, new Regex("/.*"), _ 
            => new ResponseEntity(ResponseCodes.NoContent)
        );

        server.AddGlobalMiddleware(_ 
            => new NextMiddleWare()
                .WithHeaders(new HeaderCollection
                {
                    ["Access-Control-Allow-Origin"] = "*",
                    ["Access=Control-Request-Headers"] = "*" // change this in a future
                })
        );
        
        return Task.CompletedTask;
    }

    public override void Dispose()
    {
        GC.SuppressFinalize(this);
        base.Dispose();
        server.Dispose();
    }
}