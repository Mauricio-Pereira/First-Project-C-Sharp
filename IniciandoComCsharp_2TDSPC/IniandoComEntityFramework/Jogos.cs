namespace IniandoComEntityFramework;

public class Jogos
{
    public int ID { get; set; }
    public string NOME { get; set; }
    public string DISTRIBUIDORA { get; set; }

    public Jogos(string nome, string distribuidora)
    {
        NOME = nome;
        DISTRIBUIDORA = distribuidora;
    }
}