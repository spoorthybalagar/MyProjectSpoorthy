﻿using System;
using System.Collections.Generic;

namespace DbFirstApprochWith2Tables.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public decimal? Grade { get; set; }

    public int CourseId { get; set; }

    public int StudentId { get; set; }

    public virtual Course? Course { get; set; } = null!;

    public virtual Student? Student { get; set; } = null!;
}
