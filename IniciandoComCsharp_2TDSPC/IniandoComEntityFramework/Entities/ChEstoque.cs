using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChEstoque
{
    public decimal CodEstoque { get; set; }

    public decimal? CodProduto { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal ChClienteCodCliente { get; set; }

    public virtual ChCliente ChClienteCodClienteNavigation { get; set; } = null!;

    public virtual ICollection<ChProduto> ChProdutos { get; set; } = new List<ChProduto>();
}
