using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpDevolucao
{
    public decimal CodDevolucao { get; set; }

    public DateTime? DataDevolucao { get; set; }

    public string? Observacoes { get; set; }

    public decimal? CodEmprestimo { get; set; }

    public virtual CpEmprestimo? CodEmprestimoNavigation { get; set; }
}
