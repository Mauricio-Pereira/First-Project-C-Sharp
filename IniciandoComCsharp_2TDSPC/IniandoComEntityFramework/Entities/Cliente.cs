using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Cliente
{
    public decimal CodCliente { get; set; }

    public string? Nome { get; set; }

    public decimal CodEnderecoCliente { get; set; }

    public virtual ICollection<ClienteFisico> ClienteFisicos { get; set; } = new List<ClienteFisico>();

    public virtual ICollection<ClienteJurica> ClienteJuricas { get; set; } = new List<ClienteJurica>();

    public virtual EnderecoCliente CodEnderecoClienteNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
