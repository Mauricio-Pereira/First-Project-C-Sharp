using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class EnderecoCliente
{
    public decimal CodEndereco { get; set; }

    public decimal? Numero { get; set; }

    public decimal? Cep { get; set; }

    public string? Referencia { get; set; }

    public decimal CodBairro { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Bairro CodBairroNavigation { get; set; } = null!;
}
