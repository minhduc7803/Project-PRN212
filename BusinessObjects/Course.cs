using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Course
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public byte? Credits { get; set; }

    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
