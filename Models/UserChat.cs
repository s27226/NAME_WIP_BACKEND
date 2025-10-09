namespace NAME_WIP_BACKEND.Models;

public class UserChat
{
    public int Id { get; set; }
    public int ChatId { get; set; }
    public int UserId { get; set; }

    public Chat Chat { get; set; } = null!;
    public User User { get; set; } = null!;
    public ICollection<Entry> Entries { get; set; } = new List<Entry>();
}