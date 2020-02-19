using Microsoft.AspNetCore.Hosting;
using Serilog;
using System;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace MicroService.ApiGateway
{
    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                Log.Information("Starting web host.");
                BuildWebHostInternal(args).Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHost BuildWebHostInternal(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(configure =>
                {
                    configure
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>()
                        .UseSerilog();
                })
                .Build();
    }
}
