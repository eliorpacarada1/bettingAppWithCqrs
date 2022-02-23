using BettingSite2.Data;
using BettingSite2.Interfaces;
using BettingSite2.Model;
using BettingSite2.Repositories;
using BettingSite2.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IBetRepository, BetRepository>();

builder.Services.AddScoped<IBetService, BetService>();

var connectionString = builder.Configuration.GetConnectionString("MyWebApiConection");
builder.Services.AddDbContext<MyWebApiContext>(options =>
    options.UseNpgsql(connectionString));


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
