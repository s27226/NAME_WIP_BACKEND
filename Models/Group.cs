namespace NAME_WIP_BACKEND.Models;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Desc { get; set; }
    public ICollection<UserGroup> Members { get; set; } = new List<UserGroup>();
}

public class UserGroup
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int GroupId { get; set; }
    public User User { get; set; } = null!;
    public Group Group { get; set; } = null!;
}
