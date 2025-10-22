using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class UserRoleQuery
{
    [GraphQLName("alluserroles")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<UserRole> GetuUserRoles(AppDbContext context) => context.UserRoles;
    [GraphQLName("userrolebyid")]
    [UseProjection]
    public UserRole? GetUserRoleById(AppDbContext context, int id) => context.UserRoles.FirstOrDefault(g => g.Id == id);
}