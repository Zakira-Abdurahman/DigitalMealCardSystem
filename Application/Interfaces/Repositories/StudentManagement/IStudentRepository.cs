﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories.StudentManagement
{

    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
