// Repositories/StudentRepository.cs
using System.Collections.Generic;
using System.Linq;
using Application.Models;
using Infrastructure.DbContext;

namespace Application.Interfaces.Repositories.StudentManagement
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MealCardContext _context;

        public StudentRepository(MealCardContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}