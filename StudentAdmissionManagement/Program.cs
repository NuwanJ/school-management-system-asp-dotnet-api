using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentAdmissionManagement.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyApiServiceContext>(options =>
    options.UseMySql("Server=localhost;Database=tutorial;User Id=tutorial_user;Password=abcd1234;",
        new MySqlServerVersion(new Version(8, 0, 21))));


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
