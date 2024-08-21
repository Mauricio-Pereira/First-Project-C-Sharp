using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpCard
{
    public string CodCard { get; set; } = null!;

    public decimal? Collectionsid { get; set; }

    public string? Supertrunfo { get; set; }

    public string? Nome { get; set; }

    public string? NomeDeCavaleiro { get; set; }

    public string? GrupoDeCavaleiros { get; set; }

    public decimal? Soco { get; set; }

    public decimal? Chute { get; set; }

    public decimal? Tecnica { get; set; }

    public decimal? Conhecimento { get; set; }

    public decimal? Forca { get; set; }

    public virtual CpCollection? Collections { get; set; }
}
