using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class FriendRecommendationMutation
{
    public FriendRecommendation CreateFriendRecommendation(AppDbContext context, FriendRecommendationInput input)
    {
        var rec = new FriendRecommendation
        {
            RecommendedWhoId  = input.UserId,
            RecommendedForId = input.RecommendedId,
            RecValue = input.RecValue
            
        };
        context.FriendRecommendations.Add(rec);
        context.SaveChanges();
        return rec;
    }

    public FriendRecommendation? UpdateFriendRecommendation(AppDbContext context, UpdateFriendRecommendationInput input)
    {
        var rec = context.FriendRecommendations.Find(input.Id);
        if (rec == null) return null;
        if (input.UserId.HasValue) rec.RecommendedWhoId = input.UserId.Value;
        if (input.RecommendedId.HasValue) rec.RecommendedForId = input.RecommendedId.Value;
        if (input.RecValue.HasValue) rec.RecValue = input.RecValue.Value;
        context.SaveChanges();
        return rec;
    }

    public bool DeleteFriendRecommendation(AppDbContext context, int id)
    {
        var rec = context.FriendRecommendations.Find(id);
        if (rec == null) return false;
        context.FriendRecommendations.Remove(rec);
        context.SaveChanges();
        return true;
    }
}