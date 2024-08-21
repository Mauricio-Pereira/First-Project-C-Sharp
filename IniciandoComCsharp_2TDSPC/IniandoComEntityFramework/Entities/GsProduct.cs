using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsProduct
{
    public decimal ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal Stock { get; set; }

    public decimal CompanyId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsCompany Company { get; set; } = null!;

    public virtual ICollection<GsOrderItem1> GsOrderItem1s { get; set; } = new List<GsOrderItem1>();
}
