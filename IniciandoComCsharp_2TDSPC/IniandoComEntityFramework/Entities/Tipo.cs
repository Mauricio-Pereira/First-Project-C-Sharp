using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Tipo
{
    public decimal CodTipo { get; set; }

    public string? Descricao { get; set; }

    public virtual Produto? Produto { get; set; }
}
