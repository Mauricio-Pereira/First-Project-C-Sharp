using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcProdutoComposto
{
    public int CodProdutoRelacionado { get; set; }

    public int CodProduto { get; set; }

    public int? QtdProduto { get; set; }

    public int? QtdProdutoRelacionado { get; set; }

    public string? StaAtivo { get; set; }

    public DateTime? DatCadastro { get; set; }

    public DateTime? DatCancelamento { get; set; }
}
