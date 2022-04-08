using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;

var builder = WebApplication.CreateBuilder(args);
var isDevelopment = builder.Environment.IsDevelopment();
var version = Environment.Version.ToString();

// Add services to the container.

builder.Services.AddControllersWithViews().AddNewtonsoftJson();
builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = "ClientApp/build");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!isDevelopment)
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseSpaStaticFiles();
app.UseRouting();


app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    if (isDevelopment) spa.UseReactDevelopmentServer(npmScript: "start");
});


app.Run();
