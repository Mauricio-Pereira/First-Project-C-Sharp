using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsOrderItem1
{
    public decimal OrderItemId { get; set; }

    public decimal OrderId { get; set; }

    public decimal ProductId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsOrder Order { get; set; } = null!;

    public virtual GsProduct Product { get; set; } = null!;
}
