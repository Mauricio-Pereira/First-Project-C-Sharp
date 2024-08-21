using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsAddress
{
    public decimal AddressId { get; set; }

    public decimal UserId { get; set; }

    public string ZipCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Neighborhood { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string? Complement { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsUser User { get; set; } = null!;
}
