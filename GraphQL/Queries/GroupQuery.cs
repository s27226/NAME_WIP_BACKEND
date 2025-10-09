using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class GroupQuery
{
    [GraphQLName("allgroups")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Group> GetGroups(AppDbContext context) => context.Groups;
    
    [GraphQLName("groupbyid")]
    [UseProjection]
    public Group? GetGroupById(AppDbContext context, int id) => context.Groups.FirstOrDefault(g => g.Id == id);
}