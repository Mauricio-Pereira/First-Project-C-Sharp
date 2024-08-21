using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsNgo
{
    public decimal NgoId { get; set; }

    public decimal ContactUserId { get; set; }

    public string Name { get; set; } = null!;

    public string? Mission { get; set; }

    public string? Phone { get; set; }

    public string? Website { get; set; }

    public string? ContactEmail { get; set; }

    public decimal? TotalDonations { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsUser ContactUser { get; set; } = null!;

    public virtual ICollection<GsDonation> GsDonations { get; set; } = new List<GsDonation>();
}
