using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChCliente
{
    public decimal CodCliente { get; set; }

    public string? Nome { get; set; }

    public string? Sobrenome { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Telefone { get; set; }

    public string? EmailCorporativo { get; set; }

    public string? NomeUsuario { get; set; }

    public string? Senha { get; set; }

    public virtual ChEndereco? ChEndereco { get; set; }

    public virtual ICollection<ChEstoque> ChEstoques { get; set; } = new List<ChEstoque>();
}
