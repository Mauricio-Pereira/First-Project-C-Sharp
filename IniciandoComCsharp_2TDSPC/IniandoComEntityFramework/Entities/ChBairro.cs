using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChBairro
{
    public decimal CodBairro { get; set; }

    public string? Nome { get; set; }

    public decimal ChCidadeCodCidade { get; set; }

    public virtual ChCidade ChCidadeCodCidadeNavigation { get; set; } = null!;

    public virtual ICollection<ChEndereco> ChEnderecos { get; set; } = new List<ChEndereco>();
}
