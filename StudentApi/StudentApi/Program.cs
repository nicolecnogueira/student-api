using Application.Services;
using Domain.Interfaces;
using Persistence.Repositories;
using StudentApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IStudentRepository, InMemoryStudentRepository>();
builder.Services.AddScoped<StudentService>();

var app = builder.Build();

app.MapStudentEndpoints();

app.Run();