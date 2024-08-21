using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbBairro
{
    public decimal CodBairro { get; set; }

    public string? Nome { get; set; }

    public decimal TbCidadeId { get; set; }

    public virtual TbCidade TbCidade { get; set; } = null!;

    public virtual TbEndereco? TbEndereco { get; set; }
}
