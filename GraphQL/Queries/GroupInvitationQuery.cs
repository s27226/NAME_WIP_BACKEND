using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class GroupInvitationQuery
{
    [GraphQLName("allgroupinvitations")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<GroupInvitation> GetGroupInvitations(AppDbContext context) => context.GroupInvitations;
    [GraphQLName("groupinvitationbyid")]
    [UseProjection]
    public GroupInvitation? GetGroupInvitationById(AppDbContext context, int id) => context.GroupInvitations.FirstOrDefault(g => g.Id == id);
}