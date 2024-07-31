using DigitalMealCardSystem.Application.Common.Interfaces.IRepository;
using DigitalMealCardSystem.Application.Common.Interfaces.IService;
using DigitalMealCardSystem.Domain.Entities;

namespace DigitalMealCardSystem.Application.DigitalMealCardSystem.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Student> CreateStudentAsync(Student student)
    {
        // implementation
    }

    public async Task<Student> UpdateStudentAsync(Student student)
    {
        // implementation
    }

    public async Task DeleteStudentAsync(int studentId)
    {
        // implementation
    }
}
