using BlazorUI.App;
using BlazorUI.App.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string baseAddress = builder.HostEnvironment.BaseAddress;

var catalogApiUri = builder.Configuration.GetUriValue("CatalogApiUrl", baseAddress);
builder.Services.AddScoped(sp => new CatalogApiClient { BaseAddress = catalogApiUri });

await builder.Build().RunAsync();