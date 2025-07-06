using Microsoft.Extensions.Options;
using VehicleSystem.Application.Services;
using VehicleSystem.Domain.Interfaces;
using VehicleSystem.Infrastructure.Configurations;
using VehicleSystem.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.Configure<NhtsaApiConfig>(builder.Configuration.GetSection("NhtsaApi"));

builder.Services.AddScoped<IVehicleService , VehicleService>();
builder.Services.AddHttpClient<IVehicleApiClient, VehicleApiClient>((provider, client) =>
{
    var config = provider.GetRequiredService<IOptions<NhtsaApiConfig>>().Value;
    client.BaseAddress = new Uri(config.BaseUrl);
});

builder.Services.AddHttpClient();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
