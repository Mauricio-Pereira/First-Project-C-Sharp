using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class GsCompany
{
    public decimal CompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Website { get; set; } = null!;

    public decimal AdminId { get; set; }

    public string? VerificationStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GsUser Admin { get; set; } = null!;

    public virtual ICollection<GsProduct> GsProducts { get; set; } = new List<GsProduct>();
}
