using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Produto
{
    public decimal CodProduto { get; set; }

    public string? Descricao { get; set; }

    public decimal CodTipo { get; set; }

    public virtual Tipo CodTipoNavigation { get; set; } = null!;

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
}
