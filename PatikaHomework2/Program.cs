using Microsoft.EntityFrameworkCore;
using PatikaHomework2.Data.Context;
using PatikaHomework2.Service.IServices;
using PatikaHomework2.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//ef

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

//Dapper
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add db context
builder.Services.AddDbContext<EfContext>(k=> 
k.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection"))
);

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
