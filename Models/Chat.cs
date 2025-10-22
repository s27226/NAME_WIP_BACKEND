namespace NAME_WIP_BACKEND.Models;

public class Chat
{
    public int Id { get; set; }
    public int GroupId { get; set; }

    public Group Group { get; set; } = null!;
    public ICollection<UserChat> UserChats { get; set; } = new List<UserChat>();
    public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    public ICollection<SharedFile> SharedFiles { get; set; } = new List<SharedFile>();
}