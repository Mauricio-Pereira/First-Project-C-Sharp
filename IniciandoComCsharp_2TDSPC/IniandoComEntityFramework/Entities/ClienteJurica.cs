using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ClienteJurica
{
    public decimal CodPessoaJu { get; set; }

    public decimal? Cnpj { get; set; }

    public decimal? Ie { get; set; }

    public decimal CodCliente { get; set; }

    public virtual Cliente CodClienteNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
