using CoffeShop.Data;
using CoffeShop.Models.Interfaces;
using CoffeShop.Models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CoffeShopDbContext>(option =>
    option.UseSqlServer(
        builder.Configuration.GetConnectionString("CoffeShopDbContextConnection")
    )
);


builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
