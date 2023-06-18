using Microsoft.EntityFrameworkCore;
using Nagp.UserInfo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var dbPasswordEnv = Environment.GetEnvironmentVariable("DB_PASSWORD_ENV");
var dbServerNameEnv = Environment.GetEnvironmentVariable("SERVER_NAME_ENV");
var userNameEnv = Environment.GetEnvironmentVariable("USER_NAME_ENV");
var databaseNameEnv = Environment.GetEnvironmentVariable("DATABASE_NAME_ENV");
var connectionString = builder.Configuration.GetConnectionString("NagpUserDB");
var finalConnString = string.Format(connectionString, dbServerNameEnv, databaseNameEnv, userNameEnv, dbPasswordEnv);
builder.Services.AddDbContext<NagpUserDbContext>(option =>
option.UseSqlServer(finalConnString)
);

builder.Services.AddControllers();



var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
