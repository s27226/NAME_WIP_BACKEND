using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Queries;

public class FriendRecommendationQuery
{
    [GraphQLName("allfriendrecommendations")]
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<FriendRecommendation> GetFriendRecommendations(AppDbContext context) => context.FriendRecommendations;
    [GraphQLName("friendrecommentaionbyid")]
    [UseProjection]
    public FriendRecommendation? GetFriendRecommendationById(AppDbContext context, int id) => context.FriendRecommendations.FirstOrDefault(g => g.Id == id);
}