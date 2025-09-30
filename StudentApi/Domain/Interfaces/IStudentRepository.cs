using Domain.Models;

namespace Domain.Interfaces;

public interface IStudentRepository
{
    Student Add(Student student);
    IEnumerable<Student> GetAll();
    Student? GetById(int id);
}