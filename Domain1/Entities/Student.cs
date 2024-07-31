using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public CafeteriaStatus CafeteriaStatus { get; private set; }
    public decimal MonthlyAllowance { get; private set; }
    public GraduationStatus GraduationStatus { get; private set; }
    public bool TemporaryResultIssued { get; private set; }
    public bool OriginalDocumentIssued { get; private set; }

    public Student(int id, string name, string email, string phone, CafeteriaStatus cafeteriaStatus, decimal monthlyAllowance, GraduationStatus graduationStatus)
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
        CafeteriaStatus = cafeteriaStatus;
        MonthlyAllowance = monthlyAllowance;
        GraduationStatus = graduationStatus;
    }
}