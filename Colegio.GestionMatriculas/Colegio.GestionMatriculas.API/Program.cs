using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Repositorios;
using Colegio.GestionMatriculas.Servicios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

const string corsConfiguracion = "Galaxy";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BdGestionColegioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BdColegio"));
});

builder.Services.AddDbContext<SeguridadDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("BdSeguridad"));
});

//Leer configuracion JWT desde appsettings.json
var jwtSetting = builder.Configuration.GetSection("JwtSettings");

//Configurar CORS

builder.Services.AddCors(politicas =>
{
    politicas.AddPolicy(corsConfiguracion, config =>
    {
        config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

//Configurar JWT

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSetting["Issuer"],
        ValidAudience = jwtSetting["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting["SecretKey"]!))
    };
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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCors(corsConfiguracion);

app.Run();
