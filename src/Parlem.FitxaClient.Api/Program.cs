using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Application.Implementations;
using Parlem.FitxaClient.Domain.Services;
using Parlem.FitxaClient.Infrastructure.Contracts;
using Parlem.FitxaClient.Infrastructure.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGetCustomerDetails, GetCustomerDetails>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
