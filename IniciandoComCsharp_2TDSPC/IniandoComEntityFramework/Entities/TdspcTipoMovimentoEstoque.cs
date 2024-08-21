using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcTipoMovimentoEstoque
{
    public byte CodTipoMovimentoEstoque { get; set; }

    public string? DesTipoMovimentoEstoque { get; set; }

    public string? StaSaidaEntrada { get; set; }
}
