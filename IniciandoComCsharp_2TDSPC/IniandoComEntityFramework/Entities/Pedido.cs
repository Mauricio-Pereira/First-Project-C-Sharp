using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Pedido
{
    public decimal CodPedido { get; set; }

    public DateTime? Data { get; set; }

    public decimal CodCliFisico { get; set; }

    public decimal CodCliente { get; set; }

    public decimal CodGenero { get; set; }

    public decimal CodFuncionario { get; set; }

    public decimal CodPessoaJu { get; set; }

    public decimal CodGerente { get; set; }

    public virtual ClienteFisico ClienteFisico { get; set; } = null!;

    public virtual Cliente CodClienteNavigation { get; set; } = null!;

    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;

    public virtual Funcionario CodGerenteNavigation { get; set; } = null!;

    public virtual ClienteJurica CodPessoaJuNavigation { get; set; } = null!;

    public virtual ICollection<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();
}
