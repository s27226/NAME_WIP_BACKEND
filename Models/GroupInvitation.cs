namespace NAME_WIP_BACKEND.Models;

public class GroupInvitation
{
    public int Id { get; set; }
    public DateTime Sent { get; set; }
    public DateTime Expiring { get; set; }

    public int GroupId { get; set; }
    public int InvitingId { get; set; }
    public int InvitedId { get; set; }

    public Group Group { get; set; } = null!;
    public User Inviting { get; set; } = null!;
    public User Invited { get; set; } = null!;
}