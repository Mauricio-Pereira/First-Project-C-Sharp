using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcMovimentoEstoque
{
    public long SeqMovimentoEstoque { get; set; }

    public int? CodProduto { get; set; }

    public DateTime? DatMovimentoEstoque { get; set; }

    public decimal? QtdMovimentacaoEstoque { get; set; }

    public byte? CodTipoMovimentoEstoque { get; set; }
}
