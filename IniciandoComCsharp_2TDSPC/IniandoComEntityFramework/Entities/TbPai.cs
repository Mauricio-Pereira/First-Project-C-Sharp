using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbPai
{
    public decimal CodPais { get; set; }

    public string? Nome { get; set; }

    public virtual TbEstado? TbEstado { get; set; }
}
