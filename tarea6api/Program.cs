using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Tarea 6",
        Version = "v1.5",
        Description = "Documentación de mi Api con Swagger"
    });
});

var app = builder.Build();

//Habilitar Swagger y Swagger UI

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tarea 6 v1");
        c.RoutePrefix = string.Empty;
    });
}

/*metodos de la tarea*/

var trueGroup  = app.MapGroup("/asignacion").WithTags("Asignacion verdadera jose Manuel #20231156").WithDescription("Rutas de la asignación verdadera");

trueGroup.MapGet("/noticias", () => Paso1.Ejecutar());

trueGroup.MapPost("/registro_usuario", (Usuario u) => ManejadorUsuario.Registro(u));

trueGroup.MapPost("/iniciar_sesion", (DatosLogin dl) => ManejadorUsuario.IniciarSecion(dl));

trueGroup.MapPost("/registro_incidencia", (Incidencia i) => ManejadorUsuario.RegistroIncidencia(i));

trueGroup.MapGet("/clima", async (string coordenadas) => await Clima.ObtenerClima(coordenadas));














app.Run();

