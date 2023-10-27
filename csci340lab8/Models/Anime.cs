using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csci340lab8.Models;

public class Anime
{
    public int Id { get; set; }
    
    [Display(Name = "Release Date")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
}