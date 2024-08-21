using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Bairro
{
    public decimal CodBairro { get; set; }

    public string? Nome { get; set; }

    public decimal CodCidade { get; set; }

    public virtual Cidade CodCidadeNavigation { get; set; } = null!;

    public virtual ICollection<EnderecoCliente> EnderecoClientes { get; set; } = new List<EnderecoCliente>();
}
