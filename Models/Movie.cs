namespace MoviePie.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }


    public void UpdateDetails(string title, string description)
    {
        
    }
    
}