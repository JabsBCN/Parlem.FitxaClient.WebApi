using Parlem.FitxaClient.Application.Contracts;
using Parlem.FitxaClient.Application.Implementations;
using Parlem.FitxaClient.Application.Mappers;
using Parlem.FitxaClient.Domain.Services;
using Parlem.FitxaClient.Infrastructure.Contracts;
using Parlem.FitxaClient.Infrastructure.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Use cases
builder.Services.AddScoped<IGetCustomerDetails, GetCustomerDetails>();
builder.Services.AddScoped<IGetCustomerProducts, GetCustomerProducts>();
//Mappers
builder.Services.AddScoped<ICustomerMapper, CustomerMapper>();
builder.Services.AddScoped<IProductMapper, ProductMapper>();
//Services
builder.Services.AddScoped<ICustomerService, CustomerService>();
//Repositories
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
