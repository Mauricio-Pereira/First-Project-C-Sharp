using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ClienteFisico
{
    public decimal CodCliFisico { get; set; }

    public decimal? Cpf { get; set; }

    public decimal CodCliente { get; set; }

    public decimal CodGenero { get; set; }

    public virtual Cliente CodClienteNavigation { get; set; } = null!;

    public virtual Genero CodGeneroNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
