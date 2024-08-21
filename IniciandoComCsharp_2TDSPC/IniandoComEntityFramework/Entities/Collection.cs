using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Collection
{
    public decimal Id { get; set; }

    public string Name { get; set; } = null!;
}
