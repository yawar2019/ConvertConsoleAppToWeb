using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseFirstApproach.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public decimal? Fees { get; set; }
}

public enum CountryEnum
{
    [Display(Name = "United Mexican States")]
    Mexico,
    [Display(Name = "United States of America")]
    USA, Canada, France, Germany, Spain
}
