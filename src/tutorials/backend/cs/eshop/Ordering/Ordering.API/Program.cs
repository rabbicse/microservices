using Microsoft.OpenApi.Models;
using Ordering.Application;
using Ordering.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Application layer
//builder.Services.AddApplication();

// Infra layer for write
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddMediatR(cfg =>
{
    //cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.RegisterServicesFromAssemblyContaining(typeof(Program));

    //cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
    //cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
    //cfg.AddOpenBehavior(typeof(TransactionBehavior<,>));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Ordering Service", Version = "v1" });
});

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
