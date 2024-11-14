using CapivaraBeer.Domain.Interfaces.Repositories;
using CapivaraBeer.Domain.Interfaces.Services;
using CapivaraBeer.Domain.Services;
using CapivaraBeer.infrastructure.Repositories;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Models;
using CapivaraBeer.infrastructure.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Capivara Beer Curitiba",
        Version = "v1",
        Description = "Api para cadastro, atualiza��o, exclus�o e consulta da Capivara Beer",
        Contact = new OpenApiContact { Name = "Felipe", Url = new Uri("https://github.com/fgcabral88") },
        License = new OpenApiLicense { Name = "Licen�a MIT", Url = new Uri("https://opensource.com/licenses/MIT") },
        TermsOfService = new Uri("https://opensource.com/terms-of-service")
    });
});
// Configura��o da conex�o com o banco de dados
builder.Services.AddScoped<IDbConnection>(db =>
    new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));
// Registro do AutoMapper
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(ProfileAutoMapping));
// Registro do reposit�rio
builder.Services.AddScoped<ICursosRepository, CursosRepository>();
// Registro do servi�o
builder.Services.AddScoped<ICursosService, CursosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
