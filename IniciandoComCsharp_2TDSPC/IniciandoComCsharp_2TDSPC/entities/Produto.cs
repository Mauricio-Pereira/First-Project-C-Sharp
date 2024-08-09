namespace IniciandoComCsharp_2TDSPC; //no java namespace é o pacote com o mesmo nome da pasta

public class Produto
{
    int? id { get; set; }
    string? nome { get; set; }

    public Produto()
    {
        
    }
    
    public Produto(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }
    
    public override string ToString()
    {
        return $"id: {id}, nome: {nome}";
    }
}