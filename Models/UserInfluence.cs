namespace MoviePie.Models;

public class UserInfluence
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Genre { get; set; }
    public double InfluenceScore { get; set; }


    public UserInfluence(int id, int userId, string genre, double influenceScore)
    {
        Id = id;
        UserId = userId;
        Genre = genre;
        InfluenceScore = influenceScore;
    }
    
    public void UpdateUserInfluence(int userId, string genre, double scoreIncrease)
    {
        
    }
        
}