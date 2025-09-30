using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Repositories;

public class InMemoryStudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new();
    private int _nextId = 1;

    public Student Add(Student student)
    {
        student.Id = _nextId++;
        _students.Add(student);
        return student;
    }

    public IEnumerable<Student> GetAll() => _students;

    public Student? GetById(int id) =>
        _students.FirstOrDefault(s => s.Id == id);
}