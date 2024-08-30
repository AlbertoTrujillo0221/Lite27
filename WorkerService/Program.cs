using Application.Services;
using Domain.Interfaces.Application;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using WorkerService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddTransient<IServiceTransaction, ServiceTransaction>();
builder.Services.AddTransient<IGenericRepository, GenericRepository>();

var host = builder.Build();
host.Run();
