using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Models;

public class Podcast
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string ? Url { get; set; }
    //Relacionamento 1:N com Episode para o Entity Framework
    //ele é virtual para que o Entity Framework possa sobrescrever
    public virtual ICollection<Episode> Episodes { get; set; } = new Collection<Episode>();
}