using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcEstado
{
    public string CodEstado { get; set; } = null!;

    public string? NomEstado { get; set; }

    public byte? CodPais { get; set; }
}
