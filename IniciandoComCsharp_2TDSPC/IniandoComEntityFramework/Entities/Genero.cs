using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Genero
{
    public decimal CodGenero { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<ClienteFisico> ClienteFisicos { get; set; } = new List<ClienteFisico>();
}
