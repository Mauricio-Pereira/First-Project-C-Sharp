using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbCidade
{
    public decimal CodCidade { get; set; }

    public string? Nome { get; set; }

    public decimal TbEstadoId { get; set; }

    public virtual TbBairro? TbBairro { get; set; }

    public virtual TbEstado TbEstado { get; set; } = null!;
}
