using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class SharedFileQuery
{
    [GraphQLName("allsharedfiles")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<SharedFile> GetSharedFiles(AppDbContext context) => context.SharedFiles;
    
    [GraphQLName("sharedfilebyid")]
    [UseProjection]
    public SharedFile? GetSharedFileById(AppDbContext context, int id) => context.SharedFiles.FirstOrDefault(g => g.Id == id);
}