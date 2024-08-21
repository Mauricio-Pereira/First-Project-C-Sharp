using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpEmprestimo
{
    public decimal CodEmprestimo { get; set; }

    public DateTime? DataEmprestimo { get; set; }

    public DateTime? DataDevolucao { get; set; }

    public decimal? CodUsuario { get; set; }

    public decimal? CodLivro { get; set; }

    public decimal? CodHistoricoEmprestimos { get; set; }

    public decimal? CodDevolucao { get; set; }

    public virtual CpLivro? CodLivroNavigation { get; set; }

    public virtual CpUsuario? CodUsuarioNavigation { get; set; }

    public virtual ICollection<CpDevolucao> CpDevolucaos { get; set; } = new List<CpDevolucao>();

    public virtual ICollection<CpHistoricoEmprestimo> CpHistoricoEmprestimos { get; set; } = new List<CpHistoricoEmprestimo>();
}
