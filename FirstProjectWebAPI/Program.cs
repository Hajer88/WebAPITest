using AutoMapper;
using FirstProjectWebAPI.Models;
using FirstProjectWebAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FirstProjectWebAPIIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'FirstProjectWebAPIIdentityDbContextConnection' not found.");

// Add services to the container.
var connstring = builder.Configuration
    .GetConnectionString("Default");
builder.Services.AddDbContext<Appdbcontext>
    (options => options.UseSqlite(connstring));

builder.Services.AddIdentity<IdentityUser,IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Appdbcontext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICategoryService, CategorieService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllers();

app.Run();

