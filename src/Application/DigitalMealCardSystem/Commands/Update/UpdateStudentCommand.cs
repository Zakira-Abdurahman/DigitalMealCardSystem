using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalMealCardSystem.Application.DigitalMealCardSystem.Commands.Update;
public class UpdateStudentCommand : ICommand
{
    public int StudentID { get; set; }
    public required string Name { get; set; }
    // ... other properties
}
