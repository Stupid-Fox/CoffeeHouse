using CoffeeHouse.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", (CoffeeContext db) => db.Coffees.ToList());

app.Run();
