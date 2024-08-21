using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChEndereco
{
    public decimal CodEndereco { get; set; }

    public string? Logradouro { get; set; }

    public decimal? Numero { get; set; }

    public string? Complemento { get; set; }

    public decimal? Cep { get; set; }

    public decimal ChClienteCodCliente { get; set; }

    public decimal ChBairroCodBairro { get; set; }

    public virtual ChBairro ChBairroCodBairroNavigation { get; set; } = null!;

    public virtual ChCliente ChClienteCodClienteNavigation { get; set; } = null!;
}
