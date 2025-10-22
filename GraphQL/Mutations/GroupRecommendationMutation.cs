using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class GroupRecommendationMutation
{
    public GroupRecommendation CreateGroupRecommendation(AppDbContext context, GroupRecommendationInput input)
    {
        var rec = new GroupRecommendation
        {
            UserId = input.UserId,
            GroupId = input.GroupId,
            RecValue = input.RecValue
        };
        context.GroupRecommendations.Add(rec);
        context.SaveChanges();
        return rec;
    }

    public GroupRecommendation? UpdateGroupRecommendation(AppDbContext context, UpdateGroupRecommendationInput input)
    {
        var rec = context.GroupRecommendations.Find(input.Id);
        if (rec == null) return null;
        if (input.UserId.HasValue) rec.UserId = input.UserId.Value;
        if (input.GroupId.HasValue) rec.GroupId = input.GroupId.Value;
        if (input.RecValue.HasValue) rec.RecValue = input.RecValue.Value;
        context.SaveChanges();
        return rec;
    }

    public bool DeleteGroupRecommendation(AppDbContext context, int id)
    {
        var rec = context.GroupRecommendations.Find(id);
        if (rec == null) return false;
        context.GroupRecommendations.Remove(rec);
        context.SaveChanges();
        return true;
    }
}