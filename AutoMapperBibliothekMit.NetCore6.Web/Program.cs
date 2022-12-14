using AutoMapperBibliothekMit.NetCore6.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbKontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlVerbindung"));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//AutoMapper ist eine Bibliothek, die verwendet wird, um ein Objekt einem anderen Objekt zuzuordnen und
//die Daten f?r die Au?enwelt zu ?ffnen.