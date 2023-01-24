using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeuGestorMvc.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<MeuGestorMvcContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("MeuGestorMvcContext") ?? throw new InvalidOperationException("Connection string 'MeuGestorMvcContext' not found.")));

var connectionString = builder.Configuration.GetConnectionString("MeuGestorMvcContext");
builder.Services.AddDbContext<MeuGestorMvcContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapGet("/user", (HttpResponse response) => {
//    response.Headers.Add("Teste", "Paulo Rocha");
//    return new { Name = "Paulo Victor Rocha", Age = 36 };
//});


app.Run();
