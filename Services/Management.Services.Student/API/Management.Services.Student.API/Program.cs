using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Management.Services.Student.API;
using Management.Services.Student.Core.Features.Queries;
using Management.Services.Student.Core.Interfaces.Infrastructures;
using Management.Services.Student.Core.Interfaces.Services;
using Management.Services.Student.Core.Services;
using Management.Services.Student.Infrastructure.Persistence;
using Management.Services.Student.Infrastructure.Providers;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
//builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacModule()));
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
     containerBuilder.RegisterModule<AutofacModule>();
});
ConfigurationManager configurationManager = builder.Configuration;
//IConfiguration configuration = app.Configuration;
// Add services to the container.

var connectionString = configurationManager.GetConnectionString("DefaultConnection");
builder.Services.AddMvcCore(option => option.EnableEndpointRouting = false);
builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetStudentQuery).Assembly));

builder.Services.AddSwaggerGen();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

IWebHostEnvironment environment = app.Environment;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
