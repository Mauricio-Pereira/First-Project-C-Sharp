using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpUsuario
{
    public decimal CodUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CpEmprestimo> CpEmprestimos { get; set; } = new List<CpEmprestimo>();
}
