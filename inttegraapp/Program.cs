using inttegraapp.Data;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;

var builder = WebApplication.CreateBuilder(args);


//var serverVersion = new Microsoft.EntityFrameworkCore.MySqlServerVersion(new Version(8, 0, 27));

//builder.Services.AddDbContext<InttegraappContext>(options =>
//    options.UseMySql(builder.Configuration.GetConnectionString("dbContext"), serverVersion));
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
    pattern: "{controller=Contatos}/{action=Index}/{id?}");

app.Run();
