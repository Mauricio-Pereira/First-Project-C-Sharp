using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ItemPedido
{
    public int? Quantidade { get; set; }

    public int? ValorUnitario { get; set; }

    public int? ValorTotal { get; set; }

    public decimal CodPedido { get; set; }

    public decimal CodProduto { get; set; }

    public virtual Pedido CodPedidoNavigation { get; set; } = null!;

    public virtual Produto CodProdutoNavigation { get; set; } = null!;
}
