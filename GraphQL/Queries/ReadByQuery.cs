using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class ReadByQuery
{
    [GraphQLName("allreadbys")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<ReadBy> GetReadBys(AppDbContext context) => context.ReadBys;
    
    [GraphQLName("readbybyid")]
    [UseProjection]
    public ReadBy? GetReadByById(AppDbContext context, int id) => context.ReadBys.FirstOrDefault(g => g.Id == id);
}