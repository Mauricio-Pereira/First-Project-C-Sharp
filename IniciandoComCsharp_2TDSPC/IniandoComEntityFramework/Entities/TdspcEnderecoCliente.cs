using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcEnderecoCliente
{
    public int SeqEnderecoCliente { get; set; }

    public byte? CodTipoEndereco { get; set; }

    public int? CodCliente { get; set; }

    public string? DesEndereco { get; set; }

    public string? NumEndereco { get; set; }

    public string? DesComplemento { get; set; }

    public int? NumCep { get; set; }

    public string? DesBairro { get; set; }

    public int? CodCidade { get; set; }

    public string? StaAtivo { get; set; }

    public DateTime? DatCadastro { get; set; }

    public string? DatCancelamento { get; set; }
}
