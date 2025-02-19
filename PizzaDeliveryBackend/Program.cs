using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PizzaDeliveryBackend.Data;
using PizzaDeliveryBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Подключаем базу данных SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Подключаем систему Identity для пользователей
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

// Добавляем контроллеры
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
