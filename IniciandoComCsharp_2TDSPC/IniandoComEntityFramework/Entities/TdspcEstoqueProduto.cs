using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TdspcEstoqueProduto
{
    public int CodProduto { get; set; }

    public byte CodEstoque { get; set; }

    public DateTime DatEstoque { get; set; }

    public int? QtdProduto { get; set; }
}
