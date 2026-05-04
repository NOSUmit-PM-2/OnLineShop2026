using OnLineShop2026.Data;
using OnLineShop2026.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
builder.Services.AddSingleton<ICartRepository, CartRepositoryInMemory>();
builder.Services.AddSingleton<IUsersRepository, UsersRepositoryInMemory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Catalog}/{id?}");

app.Run();
