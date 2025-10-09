using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class EntryReactionQuery
{
    [GraphQLName("allentryreactions")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<EntryReaction> GetEntryReactions(AppDbContext context) => context.EntryReactions;
    [GraphQLName("entryreactionbyid")]
    [UseProjection]
    public EntryReaction? GetEntryReactionById(AppDbContext context, int id) => context.EntryReactions.FirstOrDefault(g => g.Id == id);
}