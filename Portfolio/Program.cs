using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Portfolio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepositorioProyectos ,RepositorioProyectos>();
builder.Services.AddTransient<IServicioEmail ,ServicioEmailGmail>();

builder.Services.AddLocalization();

var localizationOptions = new RequestLocalizationOptions(); 
var supportedCultures = new[]
{
    new CultureInfo("es-ES"),
    new CultureInfo("en-US"),
    new CultureInfo("it-IT")
};

localizationOptions.SupportedCultures = supportedCultures;
localizationOptions.SupportedUICultures = supportedCultures;
localizationOptions.SetDefaultCulture("en-US");
localizationOptions.ApplyCurrentCultureToResponseHeaders = true;



var app = builder.Build();

app.UseHttpsRedirection();

app.UseRequestLocalization(localizationOptions);

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

app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();