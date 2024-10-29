﻿using System;
using System.Collections.Generic;

namespace DbFirstApprochWith2Tables.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? Title { get; set; }

    public int? Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
