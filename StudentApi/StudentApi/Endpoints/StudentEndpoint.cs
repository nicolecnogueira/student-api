using Application.Services;
using Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Endpoints;

public static class StudentEndpoint
{
    public static void MapStudentEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/students", (CreateStudentDto dto, StudentService service) =>
        {
            try
            {
                var student = service.Add(dto);
                return Results.Created($"/students/{student.Id}", student);
            }
            catch (ArgumentException ex)
            {
                return Results.BadRequest(new { error = ex.Message });
            }
        });

        app.MapGet("/students", (StudentService service) => service.GetAll());

        app.MapGet("/students/{id:int}", (int id, StudentService service) =>
        {
            var student = service.GetById(id);
            return student is not null ? Results.Ok(student) : Results.NotFound(new { error = "Student not found." });
        });
    }
}