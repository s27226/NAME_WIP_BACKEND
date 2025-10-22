namespace NAME_WIP_BACKEND.Models;

public class UserGroup
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int GroupId { get; set; }

    public User User { get; set; } = null!;
    public Group Group { get; set; } = null!;
}