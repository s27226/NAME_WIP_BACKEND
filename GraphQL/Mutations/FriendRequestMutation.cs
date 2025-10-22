using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class FriendRequestMutation
{
    public FriendRequest CreateFriendRequest(AppDbContext context, FriendRequestInput input)
    {
        var request = new FriendRequest
        {
            RequesterId = input.RequesterId,
            RequesteeId = input.RequesteeId,
            Sent = DateTime.UtcNow,
            Expiring = DateTime.Now.AddHours(3)
        };
        context.FriendRequests.Add(request);
        context.SaveChanges();
        return request;
    }

    public FriendRequest? UpdateFriendRequest(AppDbContext context, UpdateFriendRequestInput input)
    {
        var request = context.FriendRequests.Find(input.Id);
        if (request == null) return null;
        if (input.RequesterId.HasValue) request.RequesterId = input.RequesterId.Value;
        if (input.RequesteeId.HasValue) request.RequesteeId = input.RequesteeId.Value;
        context.SaveChanges();
        return request;
    }

    public bool DeleteFriendRequest(AppDbContext context, int id)
    {
        var request = context.FriendRequests.Find(id);
        if (request == null) return false;
        context.FriendRequests.Remove(request);
        context.SaveChanges();
        return true;
    }
}