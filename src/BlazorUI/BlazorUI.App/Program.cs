using BlazorUI.App;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string catalogApiUrlSetting = builder.Configuration.GetValue<string>("CatalogApiUrl");
Uri catalogApiUri = Uri.IsWellFormedUriString(catalogApiUrlSetting, UriKind.Absolute) ? new Uri(catalogApiUrlSetting) : new Uri(new Uri(builder.HostEnvironment.BaseAddress), catalogApiUrlSetting);

builder.Services.AddScoped(sp => new CatalogApiClient { BaseAddress = new Uri(catalogApiUrlSetting) });

await builder.Build().RunAsync();