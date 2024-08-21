using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcProduto
{
    public int CodProduto { get; set; }

    public string? NomProduto { get; set; }

    public string? CodBarra { get; set; }

    public string? StaAtivo { get; set; }

    public DateTime? DatCadastro { get; set; }

    public DateTime? DatCancelamento { get; set; }
}
