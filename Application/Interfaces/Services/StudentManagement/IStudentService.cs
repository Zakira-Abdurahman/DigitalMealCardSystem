using System.Collections.Generic;
using Application.Models;

namespace Application.Interfaces.Services.StudentManagement
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}