using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbEndereco
{
    public decimal CodEndereco { get; set; }

    public string? Logradouro { get; set; }

    public decimal? Numero { get; set; }

    public string? Complemento { get; set; }

    public decimal TbBairroId { get; set; }

    public decimal? Cep { get; set; }

    public virtual TbBairro TbBairro { get; set; } = null!;

    public virtual TbCliente? TbCliente { get; set; }
}
