using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class CpLivro
{
    public decimal CodLivro { get; set; }

    public string? Nome { get; set; }

    public string? Autor { get; set; }

    public string? Isbn { get; set; }

    public virtual ICollection<CpEmprestimo> CpEmprestimos { get; set; } = new List<CpEmprestimo>();
}
