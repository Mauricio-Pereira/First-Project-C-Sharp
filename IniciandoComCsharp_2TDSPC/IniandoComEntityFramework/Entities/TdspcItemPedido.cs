using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcItemPedido
{
    public int CodPedido { get; set; }

    public decimal CodItemPedido { get; set; }

    public int? CodProduto { get; set; }

    public int? QtdItem { get; set; }

    public decimal? ValUnitarioItem { get; set; }

    public decimal? ValDescontoItem { get; set; }
}
