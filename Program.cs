// Program.cs
using AIMSRCollegeWebsite.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Data.SqlClient;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Get the connection string and modify it to trust the server certificate
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var sqlConnectionBuilder = new SqlConnectionStringBuilder(connectionString)
{
    TrustServerCertificate = true
};

// Add DbContext with modified connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(sqlConnectionBuilder.ConnectionString, sqlServerOptionsAction: sqlOptions =>
    {
        // Add retry logic for connection resiliency
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null);
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
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