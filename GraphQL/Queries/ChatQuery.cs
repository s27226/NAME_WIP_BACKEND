using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class ChatQuery
{
    [GraphQLName("allchats")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Chat> GetChats(AppDbContext context) => context.Chats;
    [GraphQLName("chatbyid")]
    [UseProjection]
    public Chat? GetChatById(AppDbContext context, int id) => context.Chats.FirstOrDefault(c => c.Id == id);
}