using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class ChProduto
{
    public decimal CodProduto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public decimal? Estoque { get; set; }

    public decimal ChEstoqueCodEstoque { get; set; }

    public virtual ChEstoque ChEstoqueCodEstoqueNavigation { get; set; } = null!;
}
