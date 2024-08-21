using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcUsuario
{
    public short CodUsuario { get; set; }

    public string? NomUsuario { get; set; }

    public string? StaAtivo { get; set; }
}
