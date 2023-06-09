using Microsoft.EntityFrameworkCore;
using Nagp.UserInfo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("NagpUserDB");
builder.Services.AddDbContext<NagpUserDbContext>(option =>
option.UseSqlServer(connectionString)
);

builder.Services.AddControllers();



var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
