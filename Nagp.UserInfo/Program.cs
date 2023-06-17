using Microsoft.EntityFrameworkCore;
using Nagp.UserInfo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var db_Password_Env = Environment.GetEnvironmentVariable("DB_PASSWORD_ENV");
var db_Server_Name_Env = Environment.GetEnvironmentVariable("SERVER_NAME_ENV");
//var db_Port_No_Env = Environment.GetEnvironmentVariable("PORT_NO_ENV");
var connectionString = builder.Configuration.GetConnectionString("NagpUserDB");
var finalConnString = string.Format(connectionString, db_Server_Name_Env, db_Password_Env);
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
