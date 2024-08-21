using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsDonation
{
    public decimal DonationId { get; set; }

    public decimal OrderId { get; set; }

    public decimal Amount { get; set; }

    public decimal NgoId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsNgo Ngo { get; set; } = null!;

    public virtual GsOrder Order { get; set; } = null!;
}
