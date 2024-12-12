using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MudBlazor.Services;
using MudBlazor;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PortOn.Wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Configuration.AddJsonFile("appsettings.json");
            if (builder.HostEnvironment.IsDevelopment())
            {
                builder.Configuration.AddJsonFile("appsettings.Development.json");
            }

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ServerUrl"]) });

            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
