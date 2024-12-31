var builder = WebApplication.CreateBuilder(args);

// Controllers and views
builder.Services.AddControllersWithViews();

// App
var app = builder.Build();


// Add static files and routing
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

// Start app
app.Run();
