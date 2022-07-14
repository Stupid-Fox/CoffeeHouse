using CoffeeHouse.BLL.Di;
using CoffeeHouse.BLL.Services;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Di;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBLLDependencies(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
