using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Cidade
{
    public decimal CodCidade { get; set; }

    public string? Nome { get; set; }

    public decimal CodEstado { get; set; }

    public virtual ICollection<Bairro> Bairros { get; set; } = new List<Bairro>();

    public virtual Estado CodEstadoNavigation { get; set; } = null!;
}
