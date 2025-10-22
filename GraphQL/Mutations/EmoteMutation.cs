using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class EmoteMutation
{
    public Emote CreateEmote(AppDbContext context, EmoteInput input)
    {
        var emote = new Emote { Name = input.Name };
        context.Emotes.Add(emote);
        context.SaveChanges();
        return emote;
    }

    public Emote? UpdateEmote(AppDbContext context, UpdateEmoteInput input)
    {
        var emote = context.Emotes.Find(input.Id);
        if (emote == null) return null;
        if (!string.IsNullOrEmpty(input.Name)) emote.Name = input.Name;
        context.SaveChanges();
        return emote;
    }

    public bool DeleteEmote(AppDbContext context, int id)
    {
        var emote = context.Emotes.Find(id);
        if (emote == null) return false;
        context.Emotes.Remove(emote);
        context.SaveChanges();
        return true;
    }
}