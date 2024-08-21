using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpCollection
{
    public decimal Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CpCard> CpCards { get; set; } = new List<CpCard>();
}
