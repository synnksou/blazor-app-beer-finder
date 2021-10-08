using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;

namespace testblazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();
            //builder.Services.AddProtectedBrowserStorage();

            /*    builder.Services.AddScoped<LocalAuthenticationStateProvider>();
               builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<LocalAuthenticationStateProvider>());
    */

            /*             builder.Services.AddAuthorizationCore();
             */
            //builder.Services.AddApiAuthorization();
            /*     builder.Services.AddOidcAuthentication(options =>
                {
                    builder.Configuration.Bind("Auth0", options.ProviderOptions);
                    options.ProviderOptions.ResponseType = "code";
                });
     */
            builder.Services.AddHttpClient();
            await builder.Build().RunAsync();
        }
    }
}
