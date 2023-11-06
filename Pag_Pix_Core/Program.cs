using Microsoft.EntityFrameworkCore;
using Pag_Pix_Core.Domain.Interfaces;
using Pag_Pix_Core.Repository.Adaptadores.Context;
using Pag_Pix_Core.Repository.Adaptadores.Repositories;
using Pag_Pix_Core.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthorization();

#region conexão banco
var connectionString = Environment.GetEnvironmentVariable("PAG_PIX_CONNSTRING");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
#endregion

#region injeçoes
builder.Services.AddScoped<IPagamentoService, PagamentoService>();
builder.Services.AddScoped<IPagamentoRepository, PagamentoRepositoryMysql>();
builder.Services.AddScoped<IPagamentoRepository, PagamentoRepositoryMongoDb>();
builder.Services.AddScoped<IPagamentoRepository, PagamentoRepositorySqlServer>();
builder.Services.AddSwaggerGen();
#endregion

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
