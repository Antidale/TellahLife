using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TellahLife;
using TellahLife.Features.RaceSearch;
using TellahLife.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFeApiDataService, FeApiDataService>();
builder.Services.AddScoped<IRaceState, RaceState>();

#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
await builder.Build().RunAsync();
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
