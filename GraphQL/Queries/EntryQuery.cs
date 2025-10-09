using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class EntryQuery
{
    [GraphQLName("allentries")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Entry> GetEntries(AppDbContext context) => context.Entries;
    [GraphQLName("entrybyid")]
    [UseProjection]
    public Entry? GetEntryById(AppDbContext context, int id) => context.Entries.FirstOrDefault(g => g.Id == id);
}