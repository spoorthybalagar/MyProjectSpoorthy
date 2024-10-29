using System;
using System.Collections.Generic;

namespace StudentDbApproch.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Dob { get; set; }

    public string Email { get; set; } = null!;
}
