using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Funcionario
{
    public decimal CodFuncionario { get; set; }

    public string? Nome { get; set; }

    public DateTime? DataCadastro { get; set; }

    public decimal CodCargo { get; set; }

    public decimal? CodGerente { get; set; }

    public virtual Pedido? PedidoCodFuncionarioNavigation { get; set; }

    public virtual Pedido? PedidoCodGerenteNavigation { get; set; }
}
