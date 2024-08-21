using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Jogo
{
    public decimal Id { get; set; }

    public string? Nome { get; set; }

    public string? Distribuidora { get; set; }
}
