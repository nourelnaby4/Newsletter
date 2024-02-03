using Carter;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newsletter.Api.Behavior;
using Newsletter.Api.Database;
using Newsletter.Api.Middleware;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectioString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(option =>
option.UseSqlServer(connectioString));

var assembly = Assembly.GetExecutingAssembly();
// add auto mapper
builder.Services.AddAutoMapper(assembly);

// add Fluent Validation
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));



// add Mediator service
builder.Services.AddMediatR(config =>
   config.RegisterServicesFromAssemblies(assembly));


// add carter module
builder.Services.AddCarter();
var app = builder.Build();
app.UseMiddleware<ExceptionHandlerMiddelware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarter();

app.Run();

