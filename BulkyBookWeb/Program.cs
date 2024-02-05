using BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
));
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // In production, handle errors by redirecting to the Error action in the Home controller

    app.UseHsts();
    // Enable HTTP Strict Transport Security (HSTS) in production
}

app.UseHttpsRedirection();
// Redirect HTTP requests to HTTPS

app.UseStaticFiles();
// Serve static files (like CSS, images, etc.)

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Configure the default controller route with optional parameters

app.Run();
// Start the application
