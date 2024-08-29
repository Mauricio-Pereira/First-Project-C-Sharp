using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Models;

public class Episode
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    //Chave estrangeira para Podcast 
    public int? PodcastId { get; set; }
    //Relacionamento N:1 com Podcast para o Entity Framework
    //ele é virtual para que o Entity Framework possa sobrescrever
    public virtual Podcast?Podcast { get; set; }
}