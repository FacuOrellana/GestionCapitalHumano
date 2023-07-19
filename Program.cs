using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra la implementaci�n de IAreasManager
builder.Services.AddScoped<IAreasManager, AreaManager>(); // Reemplaza 'AreasManager' con la implementaci�n real que est�s utilizando
builder.Services.AddScoped<IContratoManager, ContratoManager>();

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
