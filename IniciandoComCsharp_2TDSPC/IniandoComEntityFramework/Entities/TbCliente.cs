using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TbCliente
{
    public decimal CodCliente { get; set; }

    public string? Nome { get; set; }

    public string? Sobrenome { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Telefone { get; set; }

    public string? EmailCorporativo { get; set; }

    public string? NomeUsuario { get; set; }

    public string? Senha { get; set; }

    public decimal TbEnderecoId { get; set; }

    public virtual TbEndereco TbEndereco { get; set; } = null!;

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();
}
