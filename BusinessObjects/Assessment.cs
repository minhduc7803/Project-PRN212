using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Assessment
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public double? Percent { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();
}
