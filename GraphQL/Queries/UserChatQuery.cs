using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class UserChatQuery
{
    [GraphQLName("alluserchats")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<UserChat> GetUserChats(AppDbContext context) => context.UserChats;
    [GraphQLName("userchatbyid")]
    [UseProjection]
    public UserChat? GetUserChatById(AppDbContext context, int id) => context.UserChats.FirstOrDefault(g => g.Id == id);
}