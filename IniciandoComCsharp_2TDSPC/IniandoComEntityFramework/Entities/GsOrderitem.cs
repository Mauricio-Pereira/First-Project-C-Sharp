using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsOrderitem
{
    public decimal OrderItemId { get; set; }

    public decimal? OrderId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
