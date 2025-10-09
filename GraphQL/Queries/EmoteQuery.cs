using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class EmoteQuery
{
    [GraphQLName("allemotes")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Emote> GetEmotes(AppDbContext context) => context.Emotes;
    [GraphQLName("emotebyid")]
    [UseProjection]
    public Emote? GetEmoteById(AppDbContext context, int id) => context.Emotes.FirstOrDefault(g => g.Id == id);
}