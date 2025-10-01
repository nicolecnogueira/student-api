using Application.Utils;
using Domain.Dto;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class StudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public Student Add(CreateStudentDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
            throw new ArgumentException("Name is required");

        if (dto.Grade is null || dto.Grade < 0 || dto.Grade > 10)
            throw new ArgumentException("Grade must be between 0 and 10");

        var student = new Domain.Models.Student 
        { 
            Name = dto.Name.Trim(), 
            Grade = dto.Grade.Value 
        };

        return _repo.Add(student);
    }

    public IEnumerable<StudentResponseDto> GetAll()
        => _repo.GetAll().Select(s => new StudentResponseDto
        {
            Id = s.Id,
            Name = s.Name,
            Grade = s.Grade,
            FirstNonRepeatedLetter = s.Name.GetFirstNonRepeatedLetter()
        });

    public StudentResponseDto? GetById(int id)
    {
        var s = _repo.GetById(id);
        return s is null ? null : new StudentResponseDto
        {
            Id = s.Id,
            Name = s.Name,
            Grade = s.Grade,
            FirstNonRepeatedLetter = s.Name.GetFirstNonRepeatedLetter()
        };
    }
}