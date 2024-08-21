using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbProduto
{
    public decimal CodProduto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public decimal TbClienteId { get; set; }

    public virtual TbCliente TbCliente { get; set; } = null!;
}
