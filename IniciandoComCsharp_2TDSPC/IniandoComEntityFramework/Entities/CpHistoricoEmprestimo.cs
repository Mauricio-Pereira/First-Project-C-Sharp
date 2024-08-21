using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpHistoricoEmprestimo
{
    public decimal CodHistoricoEmprestimos { get; set; }

    public DateTime? DataEmprestimo { get; set; }

    public DateTime? DataDevolucao { get; set; }

    public decimal? CodEmprestimo { get; set; }

    public virtual CpEmprestimo? CodEmprestimoNavigation { get; set; }
}
