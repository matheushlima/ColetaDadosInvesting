using MediatR;
using Trade.Application.Commands;
using Trade.Infrastructure.Models;
using Trade.Core.Repositories;
using Trade.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("TradeCs");
builder.Services.AddDbContext<tradeContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(CreateMoedaCommand));

builder.Services.AddScoped<IAcaoRepository, AcaoRepository>();
builder.Services.AddScoped<IMoedaRepository, MoedaRepository>();

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
