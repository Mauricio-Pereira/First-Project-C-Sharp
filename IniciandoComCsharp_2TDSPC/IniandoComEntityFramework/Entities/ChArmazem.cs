using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChArmazem
{
    public decimal CodArmazem { get; set; }

    public decimal? QtdTotal { get; set; }

    public decimal ChClienteCodCliente { get; set; }
}
