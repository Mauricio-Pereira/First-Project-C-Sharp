using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChEstado
{
    public decimal CodEstado { get; set; }

    public string? Nome { get; set; }

    public decimal ChPaisCodPais { get; set; }

    public virtual ICollection<ChCidade> ChCidades { get; set; } = new List<ChCidade>();

    public virtual ChPai ChPaisCodPaisNavigation { get; set; } = null!;
}
