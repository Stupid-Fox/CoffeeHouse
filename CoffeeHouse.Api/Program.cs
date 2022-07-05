using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// получение данных
app.MapGet("/", (CoffeeContext db) => db.Users.ToList());

app.Run();