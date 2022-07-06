using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoEF;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TareasContext>(p=> p.UseInMemoryDatabase("TareaDB"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion",async([FromServices]TareasContext dbcontext)=>
{
    dbcontext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria : " + dbcontext.Database.IsInMemory());
});

app.Run();
