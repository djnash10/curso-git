using Data;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddSingleton<IDbConnection>((sp) => new SqlConnection(connString));

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//esta linea de codigo es para q Dapper.Contrib se configure correctamente en la tabla.  Esto establecerá una convención para mapear el nombre de la tabla a partir del nombre de la clase de entidad.
SqlMapperExtensions.TableNameMapper = (type) => { return "Person"; };

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
