using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class JobGrade
{
    public string? GradeLevel { get; set; }

    public decimal? LowestSal { get; set; }

    public decimal? HighestSal { get; set; }
}
