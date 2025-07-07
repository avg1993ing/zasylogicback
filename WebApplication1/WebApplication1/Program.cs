using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using Core.Mapper;
using Core.Services;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.ContextEntity;


var builder = WebApplication.CreateBuilder(args);

string cadena = builder.Configuration.GetConnectionString("MySqlConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 42));
builder.Services.AddDbContext<PruTecContext>(options => options.UseMySql(cadena, serverVersion)
.EnableSensitiveDataLogging()
.LogTo(Console.WriteLine, LogLevel.Information));

builder.Services.AddScoped<IAdminInterfaces, AdminInterfaces>(); 
builder.Services.AddScoped<IClienteService, ClienteService>();
// Add services to the container.
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappersConfig>();
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
