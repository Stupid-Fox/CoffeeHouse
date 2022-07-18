using CoffeeHouse.Api.CoffeeViewMappers;
using CoffeeHouse.Api.Middlewares;
using CoffeeHouse.BLL.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBLLServices(builder.Configuration);

builder.Services.AddAutoMapper(typeof(CoffeeViewProfile), typeof(CoffeeProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
