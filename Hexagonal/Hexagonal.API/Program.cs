using Hexagonal.Aplicacion.CasosDeUso;
using Hexagonal.Aplicacion.Puertos.Entrada;
using Hexagonal.Aplicacion.Puertos.Salida;
using Hexagonal.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Hexagonal.Infraestructura.Persistencia.AppContext>(x => x.UseSqlServer("name=DockerConnection"));

//builder.Services.AddScoped<ICrearProductoCasoUso, CrearProductoCasoUso>();
//builder.Services.AddScoped<IProductoRepositorio, ProductoRepositorio>();

builder.Services.AddScoped<ICrearProductoCasoUso, CrearProductoCasoUsoEF>();
builder.Services.AddScoped<IProductoRepositorio, ProductoRepositorioEF>();

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
