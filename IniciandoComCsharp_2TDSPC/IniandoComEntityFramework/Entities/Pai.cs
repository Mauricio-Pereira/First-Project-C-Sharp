using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Pai
{
    public decimal CodPais { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
