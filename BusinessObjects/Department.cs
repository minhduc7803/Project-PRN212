using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Department
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
