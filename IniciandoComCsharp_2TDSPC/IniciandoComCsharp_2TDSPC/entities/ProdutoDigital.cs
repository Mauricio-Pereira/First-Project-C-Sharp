namespace IniciandoComCsharp_2TDSPC;

public class ProdutoDigital : Produto
{
    public string? url { get; set; }

    public ProdutoDigital(string? url)
    {
        this.url = url;
    }

    public override string ToString()
    {
        return base.ToString() + url;
    }
}