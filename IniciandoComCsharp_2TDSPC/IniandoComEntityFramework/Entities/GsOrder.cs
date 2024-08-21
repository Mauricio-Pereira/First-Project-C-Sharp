using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsOrder
{
    public decimal OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public decimal BuyerId { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? DonationAmount { get; set; }

    public decimal? MaintenanceAmount { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsUser Buyer { get; set; } = null!;

    public virtual ICollection<GsDonation> GsDonations { get; set; } = new List<GsDonation>();

    public virtual ICollection<GsOrderItem1> GsOrderItem1s { get; set; } = new List<GsOrderItem1>();
}
