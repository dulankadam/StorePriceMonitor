using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePriceMonitor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var configuration = new ConfigurationBuilder().AddJsonFile(string.Format("logsettings.{0}.json", environment)).Build();

            try
            {
                Log.Information("Application starting up");
                await CreateHostBuilder(args).Build().RunAsync();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The application failed to start correctly.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog();
    }
}
