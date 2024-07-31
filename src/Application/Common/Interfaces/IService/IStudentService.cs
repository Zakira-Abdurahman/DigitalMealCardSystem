using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalMealCardSystem.Domain.Entities;

namespace DigitalMealCardSystem.Application.Common.Interfaces.IService;
public interface IStudentService
{
    Task<Student> CreateStudentAsync(Student student);
    Task<Student> UpdateStudentAsync(Student student);
    Task DeleteStudentAsync(int studentId);
}
