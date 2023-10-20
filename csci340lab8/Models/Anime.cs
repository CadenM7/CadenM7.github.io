using System.ComponentModel.DataAnnotations;

namespace csci340lab8.Models;

public class Anime
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
}