namespace NAME_WIP_BACKEND.Models;

public class FriendRequest
{
    public int Id { get; set; }
    public int RequesterId { get; set; }
    public int RequesteeId { get; set; }
    public DateTime Sent { get; set; }
    public DateTime Expiring { get; set; }

    public User Requester { get; set; } = null!;
    public User Requestee { get; set; } = null!;
}