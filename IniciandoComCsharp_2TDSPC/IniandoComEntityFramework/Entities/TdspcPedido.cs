using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcPedido
{
    public int CodPedido { get; set; }

    public int? CodPedidoRelacionado { get; set; }

    public int? CodCliente { get; set; }

    public short? CodUsuario { get; set; }

    public byte? CodVendedor { get; set; }

    public DateTime? DatPedido { get; set; }

    public DateTime? DatCancelamento { get; set; }

    public DateTime? DatEntrega { get; set; }

    public decimal? ValTotalPedido { get; set; }

    public decimal? ValDesconto { get; set; }

    public int? SeqEnderecoCliente { get; set; }
}
