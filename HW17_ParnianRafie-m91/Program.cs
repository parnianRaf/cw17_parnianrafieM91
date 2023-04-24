
<<<<<<< HEAD
using AppService;
using Microsoft.AspNetCore.Hosting;
=======
using AppService;
using Microsoft.AspNetCore.Hosting;
>>>>>>> 025fcf748e3ea192e10b0286c53b67a8e929d44d
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories;
using UniContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.Services.AddDbContext<UniDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("hey")));
=======
builder.Services.AddDbContext<UniDbContext>(x => x.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
>>>>>>> 025fcf748e3ea192e10b0286c53b67a8e929d44d
builder.Services.AddScoped<IRepository, Repository>();
//builder.Services.AddScoped<IService, Service>();
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

