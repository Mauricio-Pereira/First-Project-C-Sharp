using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcHistoricoPedido
{
    public decimal SeqHistoricoPedido { get; set; }

    public int CodPedido { get; set; }

    public int? CodCliente { get; set; }

    public DateTime? DatPedido { get; set; }

    public DateTime? DatCancelamento { get; set; }

    public DateTime? DatEntrega { get; set; }

    public decimal? ValTotalPedido { get; set; }

    public decimal? ValDesconto { get; set; }

    public int? SeqEnderecoCliente { get; set; }

    public byte? CodVendedor { get; set; }
}
