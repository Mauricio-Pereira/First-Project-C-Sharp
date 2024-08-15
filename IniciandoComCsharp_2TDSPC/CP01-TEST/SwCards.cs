namespace CP01_TEST;

public record SwCards( string ? Nome, string ? Descricao )
{
    public SwCards(string? Nome) : this(Nome, "")
    {
    }
};
