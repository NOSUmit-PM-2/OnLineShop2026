using OnLineShop2026.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProductRepository, ProductRepositoryInMemory>();
builder.Services.AddSingleton<ICartRepository, CartRepositoryInMemory>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();

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

app.MapControllerRoute(
    name: "users",
    pattern: "User",
    defaults: new { controller = "User", action = "Index" });
app.Run();
