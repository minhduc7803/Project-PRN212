using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Department { get; set; }

    public virtual Department? DepartmentNavigation { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
