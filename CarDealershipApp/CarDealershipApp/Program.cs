using Microsoft.EntityFrameworkCore;
using CarDealershipApp.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CarDealerContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("CarDealerContext")));

//-------------------------------------------
// Password options custom configuration
//-------------------------------------------
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequiredLength = 10;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<CarDealerContext>()
.AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//-----------------------------
// use authentication and authorization
//-----------------------------
app.UseAuthentication();
app.UseAuthorization();

//-----------------------------------------------------
// adding scoped dependancy injection
//-----------------------------------------------------
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    await ConfigureIdentity.CreateAdminAsync(scope.ServiceProvider);
}

//------------------------------------------------
// map area controller for admin area
//------------------------------------------------
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "/Admin/{controller=Home}/{action=Index}/{id?}");

//----------------------------------------------
// default map controller route
//----------------------------------------------
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
