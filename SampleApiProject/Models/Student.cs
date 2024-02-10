using System;
using System.Collections.Generic;

namespace SampleApiProject.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public decimal? Fees { get; set; }
}
