
using System.Collections.Generic;
using Application.Interfaces.Repositories.StudentManagement;
using Application.Models;
using Application.Repositories;

namespace Application.Interfaces.Services.StudentManagement
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            _repository.UpdateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _repository.DeleteStudent(id);
        }
    }
}