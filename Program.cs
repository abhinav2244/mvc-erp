using Microsoft.EntityFrameworkCore;
using mvc_erp.Models;
using mvc_erp.Services;
using mvc_erp.Services.ExaminationDashboard;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ErpDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


// Register LoginService.
// ASP.NET Core will create one instance per HTTP request.
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<ExaminationDashboardService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register ASP.NET Core Session services.
// Session is used to keep values such as EmployeeID
// available across requests after the user logs in.
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
