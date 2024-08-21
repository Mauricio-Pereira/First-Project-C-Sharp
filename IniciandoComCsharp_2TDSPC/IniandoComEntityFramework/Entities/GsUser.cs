using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsUser
{
    public decimal UserId { get; set; }

    public string Nome { get; set; } = null!;

    public string Sobrenome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? Birthdate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GsAddress> GsAddresses { get; set; } = new List<GsAddress>();

    public virtual ICollection<GsCompany> GsCompanies { get; set; } = new List<GsCompany>();

    public virtual ICollection<GsNgo> GsNgos { get; set; } = new List<GsNgo>();

    public virtual ICollection<GsOrder> GsOrders { get; set; } = new List<GsOrder>();
}
