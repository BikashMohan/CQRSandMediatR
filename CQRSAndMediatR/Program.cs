using CQRSAndMediatRDemo.Data;
using CQRSAndMediatRDemo.Repositories;
using Messaging.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatorMessageHandlers();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
