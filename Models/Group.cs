namespace NAME_WIP_BACKEND.Models;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Desc { get; set; }

    public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
    public ICollection<GroupInvitation> Invitations { get; set; } = new List<GroupInvitation>();
    public ICollection<GroupRecommendation> Recommendations { get; set; } = new List<GroupRecommendation>();
    public ICollection<Chat> Chats { get; set; } = new List<Chat>();
}

