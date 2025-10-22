namespace NAME_WIP_BACKEND.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";
    public string Nickname { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    public int? UserRoleId { get; set; }
    public UserRole? UserRole { get; set; }

    public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
    public ICollection<UserChat> UserChats { get; set; } = new List<UserChat>();
    public ICollection<EntryReaction> EntryReactions { get; set; } = new List<EntryReaction>();
    public ICollection<ReadBy> ReadBys { get; set; } = new List<ReadBy>();
}
