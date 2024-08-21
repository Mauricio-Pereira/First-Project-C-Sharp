using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChPai
{
    public decimal CodPais { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ChEstado> ChEstados { get; set; } = new List<ChEstado>();
}
