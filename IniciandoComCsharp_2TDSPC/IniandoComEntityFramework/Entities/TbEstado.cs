using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbEstado
{
    public decimal CodEstado { get; set; }

    public string? Nome { get; set; }

    public decimal TbPaisId { get; set; }

    public virtual TbCidade? TbCidade { get; set; }

    public virtual TbPai TbPais { get; set; } = null!;
}
