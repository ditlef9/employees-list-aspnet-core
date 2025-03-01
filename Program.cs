using ServiceContracts;
using Services;
using Microsoft.EntityFrameworkCore;
using Entities;

var builder = WebApplication.CreateBuilder(args);

// Controllers and views
builder.Services.AddControllersWithViews();

// Add service into IoC Container
builder.Services.AddSingleton<ICountriesService, CountriesService>();
builder.Services.AddSingleton<IPersonsService, PersonsService>();

// Add Db
builder.Services.AddDbContext<PersonsDbContext>(options => { options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]); });

// App
var app = builder.Build();

// Add static files and routing
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

// Start app
app.Run();
