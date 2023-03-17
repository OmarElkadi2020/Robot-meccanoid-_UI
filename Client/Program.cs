using MatBlazor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MeccaUI_THDxIOT.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");


            builder.Services.AddHttpClient("MeccaUI_THDxIOT.ServerAPI",
                                                      client => client.BaseAddress
                                                      = new Uri(builder.HostEnvironment.BaseAddress));

            builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("MeccaUI_THDxIOT.ServerAPI"));

            builder.Services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

            await builder.Build()
                .RunAsync();
        }
    }
}