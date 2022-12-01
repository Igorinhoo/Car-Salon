using CarSalon.Web.Data;
using CarSalon.Web.Data.Repositories;
using CarSalon.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<IModelRepository, ModelRepository>();
builder.Services.AddTransient<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddTransient<IModelEquipmentRepository, ModelEquipmentRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<IShopViewModelProvider, ShopViewModelProvider>();
builder.Services.AddTransient<IDetailsViewModelProvider, DetailsViewModelProvider>();
builder.Services.AddTransient<IStatisticsViewModelProvider, StatisticsViewModelProvider>();
builder.Services.AddTransient<IModelsViewModelProvider, ModelsViewModelProvider>();
builder.Services.AddTransient<IOrderListViewModelProvider, OrderListViewModelProvider>();
builder.Services.AddTransient<IAddViewModelProvider, AddViewModelProvider>();
builder.Services.AddTransient<IAllThingsViewModelProvider, AllThingsViewModelProvider>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
