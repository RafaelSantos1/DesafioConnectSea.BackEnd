using DesafioConnectSea.Application.AutoMapper;
using DesafioConnectSea.Application.Services;
using DesafioConnectSea.Domain.Interface.Repositories;
using DesafioConnectSea.Domain.Interface.Services;
using DesafioConnectSea.Infrastructure.Persistence.Context;
using DesafioConnectSea.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scalar.AspNetCore;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddScoped<IEscalaRepository, EscalaRepository>();
builder.Services.AddScoped<IEscalaService, EscalaService>();
builder.Services.AddScoped<IManifestoRepository, ManifestoRepository>();
builder.Services.AddScoped<IManifestoService, ManifestoService>();

builder.Services.AddAutoMapper(cfg => { }, typeof(EscalaProfile));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<DesafioConnectSeaDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DesafioConnectSea")));

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DesafioConnectSeaDbContext>();
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => Results.Redirect("/scalar"));
app.Run();
