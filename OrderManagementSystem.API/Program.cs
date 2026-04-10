using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OrderManagementDbContext>(options =>
    options.UseInMemoryDatabase("OrderDb"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();