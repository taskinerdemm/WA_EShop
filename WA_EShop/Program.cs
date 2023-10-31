using Microsoft.EntityFrameworkCore;
using WA_EShop.Models.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EshopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbSTR")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
}

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();