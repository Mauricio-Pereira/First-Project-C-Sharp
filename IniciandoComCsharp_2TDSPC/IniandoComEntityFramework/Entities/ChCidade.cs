using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChCidade
{
    public decimal CodCidade { get; set; }

    public string? Nome { get; set; }

    public decimal ChEstadoCodEstado { get; set; }

    public virtual ICollection<ChBairro> ChBairros { get; set; } = new List<ChBairro>();

    public virtual ChEstado ChEstadoCodEstadoNavigation { get; set; } = null!;
}
