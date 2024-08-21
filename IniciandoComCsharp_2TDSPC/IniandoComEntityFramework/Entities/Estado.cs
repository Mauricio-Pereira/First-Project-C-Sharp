using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Estado
{
    public decimal CodEstado { get; set; }

    public string? NomeEstado { get; set; }

    public decimal CodPais { get; set; }

    public virtual ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();

    public virtual Pai CodPaisNavigation { get; set; } = null!;
}
