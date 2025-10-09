using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class EntryReactionMutation
{
    public EntryReaction CreateEntryReaction(AppDbContext context, EntryReactionInput input)
    {
        var reaction = new EntryReaction
        {
            UserId = input.UserId,
            EntryId = input.EntryId,
            EmoteId = input.EmoteId
        };
        context.EntryReactions.Add(reaction);
        context.SaveChanges();
        return reaction;
    }

    public EntryReaction? UpdateEntryReaction(AppDbContext context, UpdateEntryReactionInput input)
    {
        var reaction = context.EntryReactions.Find(input.Id);
        if (reaction == null) return null;
        if (input.EmoteId.HasValue) reaction.EmoteId = input.EmoteId.Value;
        context.SaveChanges();
        return reaction;
    }

    public bool DeleteEntryReaction(AppDbContext context, int id)
    {
        var reaction = context.EntryReactions.Find(id);
        if (reaction == null) return false;
        context.EntryReactions.Remove(reaction);
        context.SaveChanges();
        return true;
    }
}