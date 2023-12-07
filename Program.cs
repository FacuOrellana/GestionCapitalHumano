using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra la implementación de IAreasManager
builder.Services.AddScoped<IAreasManager, AreaManager>(); // Reemplaza 'AreasManager' con la implementación real que estás utilizando
builder.Services.AddScoped<IContratoManager, ContratoManager>();
builder.Services.AddScoped<IPuestoTrabajoManager, PuestoTrabajoManager>();
builder.Services.AddScoped<IObraSocialManager, ObraSocialManager>();
builder.Services.AddScoped<ISindicatoManager, SindicatoManager>();
builder.Services.AddScoped<IEquipoTrabajoManager, EquipoTrabajoManager>();
builder.Services.AddScoped<IEmpleadoManager, EmpleadoManager>();
builder.Services.AddScoped<IDepartamentoManager, DepartamentoManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
