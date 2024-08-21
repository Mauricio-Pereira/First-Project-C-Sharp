using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcClienteVendedor
{
    public int CodCliente { get; set; }

    public byte CodVendedor { get; set; }

    public DateTime DatInicio { get; set; }

    public DateTime? DatTermino { get; set; }
}
