using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class GroupRecommendationQuery
{
    [GraphQLName("allgrouprecommendations")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<GroupRecommendation> GetGroupRecommendations(AppDbContext context) => context.GroupRecommendations;
    
    [GraphQLName("grouprecommendationbyid")]
    [UseProjection]
    public GroupRecommendation? GetGroupRecommendationById(AppDbContext context, int id) => context.GroupRecommendations.FirstOrDefault(g => g.Id == id);
}