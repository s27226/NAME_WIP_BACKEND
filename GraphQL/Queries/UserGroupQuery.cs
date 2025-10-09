using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class UserGroupQuery
{
    [GraphQLName("allusergroups")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<UserGroup> GetUserGroups(AppDbContext context) => context.UserGroups;
    [GraphQLName("usergroupbyid")]
    [UseProjection]
    public UserGroup? GetUserGroupById(AppDbContext context, int id) => context.UserGroups.FirstOrDefault(g => g.Id == id);
}