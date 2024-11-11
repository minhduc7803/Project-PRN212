using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Semester
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? Year { get; set; }

    public DateOnly? BeginDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
