namespace Exercicio_1___ModeloCP;

public record MetacriticGame(string?Name, string? Metascore, string? UserScore, string? averageScore)
{
    public MetacriticGame(string? Name, string? Metascore, string? UserScore) : this(Name, Metascore, UserScore, "")
    {
    }
};
public record MetacriticMovie(string?Name, string? Metascore, string? UserScore, string? averageScore)
{
    public MetacriticMovie(string? Name, string? Metascore, string? UserScore) : this(Name, Metascore, UserScore, "")
    {
    }
};