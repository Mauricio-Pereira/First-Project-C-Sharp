using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcCliente
{
    public int CodCliente { get; set; }

    public string? NomCliente { get; set; }

    public string? DesRazaoSocial { get; set; }

    public string? TipPessoa { get; set; }

    public long? NumCpfCnpj { get; set; }

    public DateTime? DatCadastro { get; set; }

    public DateTime? DatCancelamento { get; set; }

    public string? StaAtivo { get; set; }
}
