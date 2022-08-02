using BlazorUI.App;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string catalogApiUrl = builder.Configuration.GetValue<string>("CatalogApiUrl");
builder.Services.AddScoped(sp => new CatalogApiClient { BaseAddress = new Uri(catalogApiUrl) });

await builder.Build().RunAsync();