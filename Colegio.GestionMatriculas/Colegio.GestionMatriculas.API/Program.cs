using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Repositorios;
using Colegio.GestionMatriculas.Repositorios.Implementaciones;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios;
using Colegio.GestionMatriculas.Servicios.Implementaciones;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BdGestionColegioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BdColegio1"));
});


builder.Services.AddRepositorios();
builder.Services.AddServicios();


builder.Services.AddAutoMapper(config => ColeccionPerfilesMapperExtension.AddPerfilesMapper(config));

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
