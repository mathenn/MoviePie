namespace MoviePie.Models;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string PasswordHash { get; set; }


    public void AddFavorite(Movie movie)
    {
        
    }

    public void RemoveFavorite(Movie movie)
    {
        
    }
}