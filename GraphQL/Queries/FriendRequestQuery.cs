using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class FriendRequestQuery
{
    [GraphQLName("allfriendrequests")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<FriendRequest> GetFriendRequests(AppDbContext context) => context.FriendRequests;
    [GraphQLName("friendrequestbyid")]
    [UseProjection]
    public FriendRequest? GetFriendRequestById(AppDbContext context, int id) => context.FriendRequests.FirstOrDefault(g => g.Id == id);
}