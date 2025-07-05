using Microsoft.Extensions.Options;
using VehicleSystem.Application.Services;
using VehicleSystem.Domain.Interfaces;
using VehicleSystem.Infrastructure.Configurations;
using VehicleSystem.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
