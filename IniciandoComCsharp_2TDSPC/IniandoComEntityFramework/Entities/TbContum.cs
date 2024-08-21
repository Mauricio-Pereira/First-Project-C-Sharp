using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbContum
{
    public decimal Id { get; set; }

    public string? NumeroDaConta { get; set; }

    public decimal? Saldo { get; set; }
}
