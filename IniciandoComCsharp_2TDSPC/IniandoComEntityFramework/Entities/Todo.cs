using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Todo
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Isdone { get; set; }
}
